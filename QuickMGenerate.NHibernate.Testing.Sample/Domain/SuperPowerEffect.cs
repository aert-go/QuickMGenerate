using System;

namespace QuickMGenerate.NHibernate.Testing.Sample.Domain
{
    public class SuperPowerEffect : IHaveAnId
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}