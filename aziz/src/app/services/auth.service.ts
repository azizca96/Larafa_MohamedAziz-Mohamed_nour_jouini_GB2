// import { Injectable } from '@angular/core';
// import { Router } from '@angular/router';
// import { filter } from 'rxjs/operators';
// import * as auth0 from 'auth0-js';
// import Auth0Lock from 'auth0-lock';
// import { JwtHelperService } from '@auth0/angular-jwt';
// import { Auth0LockPasswordless } from 'auth0-lock';




// @Injectable()
// export class AuthService {

//   userProfile: any;
//   accessToken: string;
//   authenticated: boolean;
//   profile: any;
//   private roles : string[] = [] ;
//   auth0 = new auth0.WebAuth({
//     clientID: 'KGUN1lcw4NscWOvUIwhlH48iUwqlLeJM',
//     domain: 'syndicatproject.auth0.com',
//     responseType: 'id_token token',
//     audience: 'https://syndicatproject.auth0.com/userinfo',
//     redirectUri: 'http://localhost:4200/proprietaire',
//     scope: 'openid email profile '
//   });

//   lock = new Auth0Lock(
//     'KGUN1lcw4NscWOvUIwhlH48iUwqlLeJM',
//     'syndicatproject.auth0.com',{}
//   );

//   constructor(public router: Router) {
  
//   }
 
//   getAccessToken() {
//     this.auth0.checkSession({}, (err, authResult) => {
//       if (authResult && authResult.accessToken) {
//         this.getUserInfo(authResult);
        
//       } else if (err) {
//         console.log(err);
//         this.logout();
//         this.authenticated = false;
//       }
//     });
//   }

//   public getToken(): string {
//     return JSON.parse(localStorage.getItem('id_token')).token;
//   }
  

//   getUserInfo(authResult) {
//     // Use access token to retrieve user's profile and set session
//     this.auth0.client.userInfo(authResult.accessToken, (err, profile) => {
//       if (profile) {
        
//         this.setSession(authResult, profile);
        
//         localStorage.setItem('profile', JSON.stringify(profile) );

//         this.redRoleFromToken();
//       }
//     });
//   }

//   private redRoleFromToken(){
//     const token =localStorage.getItem('id_token');
//     const jwtHelper = new JwtHelperService();
//     const decodeToken = jwtHelper.decodeToken(token);
//     var role = this.roles = decodeToken['https://syndicat.com/roles'];
//     localStorage.setItem('role',role);
//   }

//   public isInRole(roleName) {
//      var getRoleFromStorage = localStorage.getItem('role');
//      if (roleName === getRoleFromStorage)    
//        return getRoleFromStorage ;
//   }
  
//   public login(): void {
//     this.auth0.authorize(); 
//   }

//   public handleAuthentication(): void {
//     this.auth0.parseHash((err, authResult) => {
//       if (authResult && authResult.accessToken && authResult.idToken) {
//         window.location.hash = '';
//         this.getUserInfo(authResult);
        
//         this.router.navigate(['/proprietaire']);
//       } 
//       // else if (err) {
//       //   this.router.navigate(['/']);
//       //   console.log(err);
//       // }
//     });
//   }

//   private setSession(authResult,profile): void {
//     console.log("authResult",authResult);
  
//     // Set the time that the Access Token will expire at
//     const expiresAt = JSON.stringify((authResult.expiresIn * 1000) + new Date().getTime());
//     localStorage.setItem('access_token', authResult.accessToken);
//     localStorage.setItem('id_token', authResult.idToken);
//     localStorage.setItem('expires_at', expiresAt);

//     this.accessToken = authResult.accessToken;
//     this.userProfile = profile;
//     this.roles = this.roles ;
//     this.authenticated = true;
    
//   }

//   public logout(): void {
//     // Remove tokens and expiry time from localStorage
//     localStorage.removeItem('access_token');
//     localStorage.removeItem('id_token');
//     localStorage.removeItem('expires_at');
//     localStorage.removeItem('profile');
//     localStorage.removeItem('role');
//     this.profile = null ;
//     this.roles = [];
//     // Go back to the home route
//     this.router.navigate(['/']);
   
//   }

//   public isAuthenticated(): boolean {
//     // Check whether the current time is past the
//     // Access Token's expiry time
//     const expiresAt = JSON.parse(localStorage.getItem('expires_at'));
//     return new Date().getTime() < expiresAt;
//   }

  

// }