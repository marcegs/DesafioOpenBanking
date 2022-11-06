import { TestBed } from '@angular/core/testing';

import { OpenBankingHttpClientService } from './open-banking-http-client.service';

describe('OpenBankingHttpClientService', () => {
  let service: OpenBankingHttpClientService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OpenBankingHttpClientService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
