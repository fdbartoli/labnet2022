import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.css'],
})
export class SuppliersComponent implements OnInit {
  nombre: string = 'Juan Perez';
  listaNombre: string[] = ['jose', 'juan', 'jorge', 'javier'];
  nombreActivo: boolean = true;

  constructor() {}

  ngOnInit(): void {}
}
