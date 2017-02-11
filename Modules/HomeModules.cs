using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook{
  public class HomeModule : NancyModule
  {
    public HomeModule
    {
      Get["/"]= _=> {
        List<Contact> allContacts = Contact.GetAll();
        return View ["index.cshtml",allContacts];
      };
      //route for contact details.This route will have id parameter.............>
      Get["/contact/{id}"] = parameters =>{
        //get Contact object with provided Id....calling static method Find to get contact object.
        Contact contact = Contact.Find(parameters.id);
        return View["/contact_detail.cshtml", contact];
      };
      Post["/contact_added"]=_ => {
        Contact newContact = new Contact (Request.Form["name"],Request.Form["phoneNumber"],Request.Form["address"]);
        return View["new_contact.cshtml", newContact];
      };
      Get["/contact/new"] =_=> View["new_contact.cshtml"];
    }
  }
