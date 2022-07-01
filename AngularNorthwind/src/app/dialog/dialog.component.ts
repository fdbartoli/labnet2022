import { Component, Inject, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormGroup,
  FormBuilder,
  Validators,
} from '@angular/forms';
import { Suppliers } from '../models/Suppliers';
import { SuppliersService } from '../services/suppliers.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css'],
})
export class DialogComponent implements OnInit {
  suppliersForm!: FormGroup;
  actionBtn: string = 'Add Supplier';
  supplierEdit!: Suppliers;
  constructor(
    private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public editData: any,
    private dialogRef: MatDialogRef<DialogComponent>,
    private suppliersService: SuppliersService
  ) {}

  ngOnInit(): void {
    this.suppliersForm = this.formBuilder.group({
      Id: [''],
      companyName: ['', [Validators.required, Validators.maxLength(40)]],
      contactName: ['', Validators.maxLength(30)],
      phone: ['', Validators.maxLength(24)],
    });

    if (this.editData) {
      this.actionBtn = 'Update Supplier';
      this.suppliersForm.controls['companyName'].setValue(
        this.editData.CompanyName
      );
      this.suppliersForm.controls['contactName'].setValue(
        this.editData.ContactName
      );
      this.suppliersForm.controls['phone'].setValue(this.editData.Phone);
      this.suppliersForm.controls['Id'].setValue(this.editData.Id);
    }
  }
  addSuppliers() {
    if (!this.editData) {
      if (this.suppliersForm.valid) {
        var suppliers = new Suppliers();
        suppliers.companyName = this.suppliersForm.get('companyName')?.value;
        suppliers.contactName = this.suppliersForm.get('contactName')?.value;
        suppliers.phone = this.suppliersForm.get('phone')?.value;
        this.suppliersService.postSupplier(suppliers).subscribe(
          (res) => {
            alert('Supplier added succesfully!');
            this.suppliersForm.reset();
            this.dialogRef.close();
          },
          (error) => alert('Error!')
        );
      }
    } else {
      this.updateSupplier();
    }
  }

  updateSupplier() {
    var suppliers = new Suppliers();
    suppliers.Id = this.suppliersForm.get('Id')?.value;
    suppliers.companyName = this.suppliersForm.get('companyName')?.value;
    suppliers.contactName = this.suppliersForm.get('contactName')?.value;
    suppliers.phone = this.suppliersForm.get('phone')?.value;
    this.suppliersService.editSupplier(suppliers).subscribe(
      (res) => {
        alert('Supplier updated succesfully!');
        this.suppliersForm.reset();
        this.dialogRef.close();
      },
      (error) => alert('Error!')
    );
  }
}
