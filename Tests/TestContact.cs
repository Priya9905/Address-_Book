using System;
using Xunit;
using AddressBook.Objects;
using System.Collections.Generic;
namespace AddressBook.Tests
{
  public class TestContact : IDisposable
  {
    [Fact]
    public void Test1_GetName_ReturnName()
    {
      //test code goes here
      //Arrange
      string name = "Shruti" ;
      string phoneNumber="54556112";
      string address = "bothell";
      Contact newContact = new Contact(name, phoneNumber, address);
      //Act
      string result = newContact.GetName();
      //Assert
      Assert.Equal(name, result);
    }
    [Fact]
    public void Test2_GetPhoneNumber_ReturnPhoneNumber(){
      //Arrange
      Contact newContact = new Contact("Kunal","454665646","Bothell");
      string result = newContact.GetPhoneNumber();
      Assert.Equal("454665646",result);

    }
    [Fact]
    public void Test3_GetAll_ReturnContactList(){

      Contact newContact1 = new Contact("Kunal","454665646","Bothell");
      Contact newContact2 = new Contact("Shruti","458965646","Bothell");
      List<Contact> newList = new List<Contact> { newContact1, newContact2 };

      List<Contact> result = Contact.GetAll();
      foreach (Contact item in result) {
        Console.WriteLine("Output is" + item.GetName());
      }
      Assert.Equal(newList,result);
    }
    public void Dispose()
    {
      Contact.ClearAll();
    }
  }
}
