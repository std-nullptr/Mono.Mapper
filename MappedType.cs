using System.Collections.Generic;

namespace Mono.Mapper
{
    public class MappedType : MappedMember
    {
        public List<MappedMember> Fields { get; set; } = new List<MappedMember>();

        public MappedType()
        {
        }

        public MappedType(string original, string mapped) : base(original, mapped)
        {
        }
    }
}