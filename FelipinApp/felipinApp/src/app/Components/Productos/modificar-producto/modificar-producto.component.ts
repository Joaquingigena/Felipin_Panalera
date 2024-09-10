import { Component, numberAttribute,Input } from '@angular/core';
import { transform } from 'typescript';

@Component({
  selector: 'app-modificar-producto',
  standalone: true,
  imports: [],
  templateUrl: './modificar-producto.component.html',
  styleUrl: './modificar-producto.component.css'
})
export class ModificarProductoComponent {

  @Input({transform:numberAttribute})
  id!:number;
}
