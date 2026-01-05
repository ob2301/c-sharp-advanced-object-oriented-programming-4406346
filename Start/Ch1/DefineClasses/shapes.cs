// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword
class Rectangle{
    public int width, height;
    public Rectangle(int width, int height)
    {
         this.width = width;
         this.height = height;
    }

    public Rectangle(int length)
    {
        this.width = length;
        this.height = length;
    }

    public int Area()
    {
        return this.width * this.height;
    }


}
