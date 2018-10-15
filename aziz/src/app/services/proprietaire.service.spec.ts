import { TestBed, inject } from '@angular/core/testing';

import { ProprietaireService } from './proprietaire.service';

describe('ProprietaireService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProprietaireService]
    });
  });

  it('should be created', inject([ProprietaireService], (service: ProprietaireService) => {
    expect(service).toBeTruthy();
  }));
});
