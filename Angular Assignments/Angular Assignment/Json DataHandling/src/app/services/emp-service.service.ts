import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, retry, catchError, throwError } from 'rxjs';
import { Employees } from '../employees';

@Injectable({
  providedIn: 'root'
})
export class EmpServiceService {
 url='http://localhost:3000'
  constructor(private http:HttpClient) { }
  httpOptions={
    headers:new HttpHeaders ({
      'Content-Type':'application/json'
    })
  }
  
  getEmp():Observable<Employees>{
    return this.http.get<Employees>(this.url+'/employees')
    .pipe(
      retry(1),catchError(this.handleError)
    )
  }
  getEmployee(id: number): Observable<any> {
    return this.http.get(`${this.url}/employees/${id}`)
      .pipe(
        retry(1),
        catchError(this.handleError)
      );
  }
  handleError(error:{error:{message:string;};status:any;message:any}){
    let errorMessage = ''
    if(error.error instanceof ErrorEvent){
      errorMessage = error.error.message
    }else{
      errorMessage= `Error Code:${error.status}\nMessage:${error.message}`
    }
    window.alert(errorMessage)
    return throwError(errorMessage)
  }
}
