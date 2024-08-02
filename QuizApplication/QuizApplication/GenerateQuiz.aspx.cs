using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizApplication
{
    public partial class GenerateQuiz : System.Web.UI.Page
    {
        private QuizEntities db = new QuizEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var questions = db.Questions
                                  .OrderBy(q => Guid.NewGuid())
                                  .Take(10)
                                  .ToList();
                QuizRepeater.DataSource = questions;
                QuizRepeater.DataBind();
            }

        }
        protected void QuizRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
                var question = (Question)e.Item.DataItem;
                var options = new[]
                {
                    new { Text = question.Option1, Value = question.Option1 },
                    new { Text = question.Option2, Value = question.Option2 },
                    new { Text = question.Option3, Value = question.Option3 },
                    new { Text = question.Option4, Value = question.Option4 }
                };


                var radioButtonList = (RadioButtonList)e.Item.FindControl("Options");
                radioButtonList.DataSource = options;
                radioButtonList.DataTextField = "Text";
                radioButtonList.DataValueField = "Value";
                radioButtonList.DataBind();
            
        }

        protected void SubmitQuiz_Click(object sender, EventArgs e)
        {
            int correctAnswers = 0;

            foreach (RepeaterItem item in QuizRepeater.Items)
            {
                int questionId = int.Parse(((HiddenField)item.FindControl("QuestionId")).Value);
                string selectedOption = ((RadioButtonList)item.FindControl("Options")).SelectedValue;

                var question = db.Questions.First(q => q.Id == questionId);
                if (question != null)
                {
                    var feedbackLabel = (Label)item.FindControl("FeedbackLabel");

                    if (question.CorrectOption == selectedOption)
                    {
                        correctAnswers++;
                        feedbackLabel.Text = "Correct";
                        feedbackLabel.CssClass = "correct-answer";
                    }
                    else
                    {
                        feedbackLabel.Text = $"Wrong. Correct answer: {question.CorrectOption}";
                        feedbackLabel.CssClass = "wrong-answer";
                    }
                }
            }

            ResultLabel.Text = $"Your Score: {correctAnswers} / 10";
            SubmitQuiz.Enabled = false;
            SubmitQuiz.Text = "Submitted";
        }
    }
}
