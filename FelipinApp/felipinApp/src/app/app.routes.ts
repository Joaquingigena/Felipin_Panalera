import { Routes } from '@angular/router';
import { ProductoComponent } from './Components/Productos/producto/producto.component';
import { LoginComponent } from './Components/Login/login/login.component';
import { CategoriaComponent } from './Components/Categorias/categoria/categoria.component';
import { MarcaComponent } from './Components/Marcas/marca/marca.component';
import { CrearProductoComponent } from './Components/Productos/crear-producto/crear-producto.component';
import { DetalleProductoComponent } from './Components/Productos/detalle-producto/detalle-producto.component';
import { ModificarProductoComponent } from './Components/Productos/modificar-producto/modificar-producto.component';

export const routes: Routes = [
    {path:"",component: ProductoComponent},
    {path:"login",component:LoginComponent},

    {path:"categorias",component:CategoriaComponent},
    {path:"marcas", component:MarcaComponent},
    {path:"productos",component:ProductoComponent},
    {path:"crearProducto",component:CrearProductoComponent},
    {path:"detalleProducto/:id",component:DetalleProductoComponent},
    {path:"modificarProducto/:id",component:ModificarProductoComponent},
    {path:"**",redirectTo:""}

];
