import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormGroup,
  FormBuilder,
  Validators,
} from '@angular/forms';
import { Suppliers } from '../models/Suppliers';
import { SuppliersService } from '../services/suppliers.service';

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css'],
})
export class DialogComponent implements OnInit {
  suppliersForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private suppliersService: SuppliersService
  ) {}

  ngOnInit(): void {
    this.suppliersForm = this.formBuilder.group({
      companyName: ['', [Validators.required, Validators.maxLength(40)]],
      contactName: [''],
      phone: [''],
    });
  }
  addProduct() {
    if (this.suppliersForm.valid) {
      var suppliers = new Suppliers();
      suppliers.companyName = this.suppliersForm.get('companyName')?.value;
      suppliers.contactName = this.suppliersForm.get('contactName')?.value;
      suppliers.phone = this.suppliersForm.get('phone')?.value;
      this.suppliersService.postSupplier(suppliers).subscribe(
        (res) => {
          alert('Supplier added succesfully!');
          this.suppliersForm.reset();
        },
        (error) => alert('Error!')
      );
      // this.suppliersService.postSupplier(this.suppliersForm.value).subscribe({
      //   next: (res) => {
      //     alert('added succesfully!');
      //   },
      //   error: () => {
      //     alert('error');
      //   },
      // });
    }
  }

  // var suppliers = new Suppliers();
  // suppliers.companyName = this.suppliersForm.get('companyName')?.value;
  // suppliers.contactName = this.suppliersForm.get('contactName')?.value;
  // suppliers.phone = this.suppliersForm.get('phone')?.value;

  // this.suppliersService.postSupplier(suppliers).subscribe((res) => {
  //   console.log('se guardo el producto' + res);
  // });
}
