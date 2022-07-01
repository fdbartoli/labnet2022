import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Suppliers } from '../models/Suppliers';
import { SuppliersService } from '../services/suppliers.service';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { DialogComponent } from '../dialog/dialog.component';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.css'],
})
export class SuppliersComponent implements OnInit {
  displayedColumns: string[] = [
    'id',
    'CompanyName',
    'ContactName',
    'Phone',
    'Action',
  ];
  dataSource!: MatTableDataSource<any>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private suppliersService: SuppliersService,
    private dialog: MatDialog
  ) {}

  ngOnInit(): void {
    this.getAllSuppliers();
  }
  getAllSuppliers() {
    this.suppliersService.getsuppliers().subscribe({
      next: (res) => {
        this.dataSource = new MatTableDataSource(res);
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
      },
      error: () => {
        alert('Error while feteching');
      },
    });
  }

  editSupplier(row: any) {
    this.dialog
      .open(DialogComponent, {
        width: '50%',
        data: row,
      })
      .afterClosed()
      .subscribe((val) => {
        if (val === 'save') {
        }
        window.location.reload();
      });
  }

  deleteSupplier(id: number) {
    this.suppliersService.deleteSupplier(id).subscribe({
      next: (res) => {
        alert('Deleted Succesfully');
        window.location.reload();
      },
      error: () => {
        alert('Error while deleting this supplier');
      },
    });
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
}
