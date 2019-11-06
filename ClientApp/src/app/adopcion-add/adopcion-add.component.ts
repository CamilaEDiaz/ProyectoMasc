import { Component, OnInit } from '@angular/core';
import {AdopcionService} from '../services/adopcion.service';
import { Adopcion } from '../models/adopcion';
import { from } from 'rxjs';

@Component({
  selector: 'app-adopcion-add',
  templateUrl: './adopcion-add.component.html',
  styleUrls: ['./adopcion-add.component.css']
})
export class AdopcionAddComponent implements OnInit {

  constructor( private adopcionService: AdopcionService ) { }
  adopcion : Adopcion;
 ngOnInit() {
   this.adopcion = {codpersonna : 0, nombrecompleto: "",telefono:0,direccion: "" ,sexo:"",edad:0,}
 }

 add() {
   this.adopcionService.addAdopcion(this.adopcion)
   .subscribe(adopcion => {
   alert('Se agrego una nueva persona')
   });
   }

}
