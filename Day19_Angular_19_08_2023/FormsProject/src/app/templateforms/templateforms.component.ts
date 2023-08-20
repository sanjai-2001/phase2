
import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-templateforms',
  templateUrl: './templateforms.component.html',
  styleUrls: ['./templateforms.component.css']
})

export class TemplateformsComponent {
  
contact !: contact;

countryList: country[] =
    [
      new country("1", "India"),
      new country('2', 'USA'),
      new country('3', 'England')
    ];

onSubmit(contactForm: any)
{
  console.log(this.contact);
}

  setDefaults() {
    this.contact = {
      firstname: "Sachin",
      lastname: "Tendulkar",
      email: "sachin@gmail.com",
      gender: "male",
      isMarried: true,
      country: "1",
      address: { city: "Mumbai", street: "Perry Cross Rd", pincode: "400050" }
    };
  }
 
  ngOnInit() 
  {
    this.contact = {
      firstname: "Sachin",
      lastname: "Tendulkar",
      email: "sachin@gmail.com",
      gender: "male",
      isMarried: true,
      country: "1",
      address: { city: "Mumbai", street: "Perry Cross Rd", pincode: "400050" }
    };
  }

  reset(contactForm :NgForm) {
    contactForm.resetForm();
  }
}

export class country {
    id: string;
    name: string;
  
    constructor(id: string, name: string) {
      this.id = id;
      this.name = name;
    }
  }

export class contact {
  firstname: string = '';
  lastname: string = '';
  email: string = '';
  gender: string = '';
  isMarried: boolean = false;
  country: string = '';
  address!: {
    city: string;
    street: string;
    pincode: string;
  };
}
