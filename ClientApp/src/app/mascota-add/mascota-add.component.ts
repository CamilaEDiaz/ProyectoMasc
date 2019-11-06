import { Component, OnInit } from '@angular/core';
import { MascotaService } from '../services/mascota.service';
import { Mascota } from '../models/mascota';

@Component({
  selector: 'app-mascota-add',
  templateUrl: './mascota-add.component.html',
  styleUrls: ['./mascota-add.component.css']
})
export class MascotaAddComponent implements OnInit {

  constructor( private mascotaService: MascotaService ) { }
   mascota : Mascota;
  ngOnInit() {
    this.mascota = {nombre : "", sexo: "", raza:"", tipomascota: 0, descripcion:""}
  }

  add() {
    this.mascotaService.addMascota(this.mascota)
    .subscribe(mascota => {
    alert('Se agrego una nueva tarea')
    });
    }

}
