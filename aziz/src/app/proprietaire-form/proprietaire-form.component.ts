import { Proprietaire } from './../models/proprietaire';
import { ProprietaireService } from './../services/proprietaire.service';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-proprietaire-form',
  templateUrl: './proprietaire-form.component.html',
  styleUrls: ['./proprietaire-form.component.css']
})
export class ProprietaireFormComponent implements OnInit {

  proprietaires= [] ;
  proprietaire: Proprietaire = {
    id:0 ,
    nom: '',
    password:'',
    login:'',
    telephoneFixe:'',
    telephonePortable:'',
    email:''
  };
  

  constructor(
    private proprietaireService : ProprietaireService ,
    private toastr: ToastrService,
    private route : ActivatedRoute,
    private router : Router
    ) 
   {
    route.params.subscribe(p => {
      this.proprietaire.id = +p['id'];
      console.log(this.proprietaire.id);
    })
   }

  ngOnInit() {
    this.proprietaireService.getProprietaires(this.proprietaire.id).subscribe( p => {
      this.proprietaire = p ;
    }

    /* Probleme here !!!!! */
    // , err => {
    //    if (err.status == 404)
    //     this.router.navigate(['/home']);
    // }
  );
  }

  onIdChange(){
    console.log("chosenId" , this.proprietaire) 
    var selectedProp = this.proprietaires.find(p => p.id == this.proprietaire.id);
    console.log("" , selectedProp) 
    
  }

  submit(){
    if (this.proprietaire.id)
      this.proprietaireService.update(this.proprietaire).subscribe(toast => {
        this.toastr.success("Success" , "Update",{
          timeOut : 3000 ,
          closeButton : true })
      })
    else {
      this.proprietaireService.create(this.proprietaire)
      .subscribe(
        toast => {
          this.toastr.success("Success")
        });
    }
        
  }

  delete(){
    if (confirm("Are you sure to delete this Proprietaire")) {
      this.proprietaireService.delete(this.proprietaire.id).subscribe( p => {
        this.router.navigate(['/home']);
      })
    }
  }

}
