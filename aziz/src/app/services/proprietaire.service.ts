import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Http, RequestOptions , Response, Headers } from '@angular/http';
import 'rxjs/add/operator/map';
import { catchError, map, tap } from 'rxjs/operators';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { Proprietaire } from '../models/proprietaire';
import { MessageService } from './message.service';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()
export class ProprietaireService {


  constructor(private http : HttpClient, private messageService: MessageService ) { }

private readonly Endpoint = 'http://localhost:60660/api/proprietaires';

  
  
  create(proprietaire:Proprietaire): Observable<Proprietaire>{
    return this.http.post<Proprietaire>(this.Endpoint,proprietaire,httpOptions).pipe(
      tap((proprietaire: Proprietaire) => this.log(`added proprietaire w/ id=${proprietaire.id}`)),
      catchError(this.handleError<Proprietaire>('addProprietaire'))
    );
  //  .map(res=> res.json());
  }

  getProprietaire(filter): Observable<Proprietaire[]>{
    return this.http.get<Proprietaire[]>('http://localhost:60660/api/proprietaires')
    .pipe(
      tap(proprietaire => this.log(`fetched proprietaires`)),
      catchError(this.handleError('getHeroes', []))
    );
    //.map(res => res.json());
  }

  toQueryString(obj){
    var parts = [];
    for (var property in obj){
      var value = obj[property];
      if (value != null && value != undefined)
        parts.push(encodeURIComponent(property) +'='+ encodeURIComponent(value));   
    }
    return parts.join('&');
  }

  getProprietaires(id)
  {
    return this.http.get(this.Endpoint+ '/' + id )
    .map(res => res.json()) ;
  }

  update(proprietaire)
  {
    return this.http.put(this.Endpoint+ '/' + proprietaire.id , proprietaire )
    .map(res => res.json()) ;
  }

  delete(id){
    return this.http.delete(this.Endpoint+ '/' + id )
    .map(res => res.json()) ;
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
  
    /** Log a HeroService message with the MessageService */
    private log(message: string) {
      this.messageService.add('ProprietaireService: ' + message);
    }
}
