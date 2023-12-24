namespace DateTimeAndGeneric_Non_Generic
{
    public class User<T>
    {
        public int Id { get; set; }
        public T Point { get; set; }
    }
}
