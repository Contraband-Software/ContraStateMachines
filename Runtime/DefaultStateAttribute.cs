using System;

namespace Software.Contraband.StateMachines
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class DefaultStateAttribute : Attribute { }
}