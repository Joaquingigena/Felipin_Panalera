import { Component, inject } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { RouterLink } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-producto',
  standalone: true,
  imports: [MatButtonModule,RouterLink],
  templateUrl: './producto.component.html',
  styleUrl: './producto.component.css'
})
export class ProductoComponent {

  private router= inject(Router);

  productos= [
    {
      id:1,
      nombre: "BabySec Premium XXG",
      descripcion: "Pañal medio pelo",
      img: "https://acdn.mitiendanube.com/stores/139/588/products/babysecpremiumsoftxxg-c274094b94e15d61d817068218708274-1024-1024.jpg",
      precio: 100
    },
    {
      id:2,
      nombre: "Huggies Classic XG",
      descripcion: "Pañal medio pelo amarillo",
      img: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS5pR4PlK1feaTIKW6FZi-GUPLui8rLuU0B4w&s",
      precio: 100
    },
    {
      id:3,
      nombre: "Pampers Premium Care",
      descripcion: "Pañal cheto",
      img: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7-sxQmlOLd0g2PssU7ebnL16ObpDujb9k1w&s",
      precio: 100
    }
  ];

  crearProducto(){
    
    this.router.navigate(["/crearProducto"]);
  }
}

