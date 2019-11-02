import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  employees: any;
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getValues();
  }

  getValues() {
    return this.http.get('https://localhost:5001/value').subscribe(
      response => {
        this.employees = response;
        console.log(this.employees);
      },
      error => {
        console.log(error);
      }
    );

  }
}
