import { Title } from '@angular/platform-browser';
import { Proprietaire } from './../models/proprietaire';
import { ProprietaireService } from './../services/proprietaire.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-proprietaire-list',
  templateUrl: './proprietaire-list.component.html',
  styleUrls: ['./proprietaire-list.component.css']
})
export class ProprietaireListComponent implements OnInit {
  private readonly PAGE_SIZE = 7;
  proprietaire=[];
  filter :any = {
    pageSize : this.PAGE_SIZE 
  } ;
  columns = [
    {title:'Id'},
    {title:'Nom', key: 'nom' , isSortable : true},
    {title:'Password', key: 'password' , isSortable : true},
    {title:'Email', key: 'email' , isSortable : true},
    {title:'Login', key: 'login' , isSortable : true},
    {title:'Telephone Fixe'},
    {title:'Telephone Portable'},
  ];
  constructor(private proprietaireService: ProprietaireService) { }
  
    ngOnInit() { 
      this.populateProprietaire();
     
    }

    private populateProprietaire(){
      this.proprietaireService.getProprietaire(this.filter)
      .subscribe(proprietaire => this.proprietaire  =  proprietaire);
    }
    onFilterChange(){
      this.filter.page = 1
      this.populateProprietaire();
    }

    resetFilter(){
      this.filter ={
        page: 1,
        pageSize: this.PAGE_SIZE
      };
      this.populateProprietaire();
    }

    sortBy(colomnName){
      if(this.filter.sortBy === colomnName){
        this.filter.isSortAscending = !this.filter.isSortAscending ;
      } else {
        this.filter.sortBy = colomnName;
        this.filter.isSortAscending = true; 
      }
      this.populateProprietaire();
    }

    onPageChange(page) {
         this.filter.page = page; 
          this.populateProprietaire();
        }
}
