import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Suppliers } from '../models/Suppliers';
import { SuppliersService } from '../services/suppliers.service';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.css'],
})
export class SuppliersComponent implements OnInit {
  listadoSuppliers: Suppliers[] = [];
  constructor(private suppliersService: SuppliersService) {}

  ngOnInit(): void {
    this.suppliersService.getsuppliers().subscribe((resp) => {
      this.listadoSuppliers = resp;
    });
  }
}
