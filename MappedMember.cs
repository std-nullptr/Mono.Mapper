namespace Mono.Mapper
{
    public class MappedMember
    {
        public string Original { get; set; }

        public string Mapped { get; set; }

        public MappedMember()
        {
        }

        public MappedMember(string original, string mapped)
        {
            Original = original;
            Mapped = mapped;
        }
    }
}