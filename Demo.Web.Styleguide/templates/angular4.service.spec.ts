// Straight Jasmine - no imports from Angular test libraries
import {DataService} from './angular4.service';

describe('FancyService without the TestBed', () => {
  let service: DataService;

  beforeEach(() => { service = new DataService(); });

  it('#getValue should return real value', () => {
    expect(service.getValue()).toBe('real value');
  });

  it('#getAsyncValue should return async value', (done: DoneFn) => {
    service.getAsyncValue().then(value => {
      expect(value).toBe('async value');
      done();
    });
  });

  it('#getTimeoutValue should return timeout value',  (done: DoneFn) => {
    service = new DataService();
    service.getTimeoutValue().then(value => {
      expect(value).toBe('timeout value');
      done();
    });
  });

  it('#getObservableValue should return observable value', (done: DoneFn) => {
    service.getObservableValue().subscribe(value => {
      expect(value).toBe('observable value');
      done();
    });
  });

});
