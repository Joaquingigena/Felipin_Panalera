import { Component, inject } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, RequiredValidator, Validators } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import{Router, RouterLink} from '@angular/router';

@Component({
  selector: 'app-categoria',
  standalone: true,
  imports: [MatButtonModule,RouterLink,MatFormFieldModule,ReactiveFormsModule,MatInputModule],
  templateUrl: './categoria.component.html',
  styleUrl: './categoria.component.css'
})
export class CategoriaComponent {

  private formBuilder= inject(FormBuilder);

  form= this.formBuilder.group({
    nombre:["",Validators.required]
  });

  router = inject(Router);

  guardarCambios(){
    
    console.log(this.form.value);
  }
}
