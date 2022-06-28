import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-suppliers-forms',
  templateUrl: './suppliers-forms.component.html',
  styleUrls: ['./suppliers-forms.component.css'],
})
export class SuppliersFormsComponent implements OnInit {
  formSuppliers!: FormGroup;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.formSuppliers = this.formBuilder.group({
      companyName: new FormControl('', Validators.required),
      password: new FormControl(''),
      ContactName: new FormControl(''),
    });
  }
}
