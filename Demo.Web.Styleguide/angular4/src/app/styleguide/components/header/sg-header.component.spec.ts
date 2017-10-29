import { SgHeaderComponent } from './sg-header.component';

import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By }           from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

describe('SgHeaderComponent', function () {
  let de: DebugElement;
  let comp: SgHeaderComponent;
  let fixture: ComponentFixture<SgHeaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SgHeaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SgHeaderComponent);
    comp = fixture.componentInstance;
    de = fixture.debugElement.query(By.css('strong'));
  });

  it('should create component', () => expect(comp).toBeDefined() );

  /*
  it('should have expected <strong> text', () => {
    fixture.detectChanges();
    const h1 = de.nativeElement;
    expect(h1.innerText).toMatch(/angular/i,
      '<strong> should say something about "Angular"');
  });
  */
});
