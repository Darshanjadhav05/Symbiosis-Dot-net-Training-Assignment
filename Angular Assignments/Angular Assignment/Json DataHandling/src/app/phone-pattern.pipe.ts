import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'phonePattern',
  standalone: true
})
export class PhonePatternPipe implements PipeTransform {
  

  transform(str:string): string {
    return `${str.substring(0,4)}-${str.substring(4,8)}-${str.substring(8,12)}`;
  }

}
