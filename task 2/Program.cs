
var photoBook = new PhotoBook();
System.Console.WriteLine(photoBook.GetNumberPages());

var _photoBook = new PhotoBook(24);
System.Console.WriteLine(_photoBook.GetNumberPages());

var largePhotoBook = new BigPhotoBook();
System.Console.WriteLine(largePhotoBook.GetNumberPages());


