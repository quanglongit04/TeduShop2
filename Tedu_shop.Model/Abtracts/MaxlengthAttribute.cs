using System;

namespace Tedu_shop.Model.Abtracts
{
    internal class MaxlengthAttribute : Attribute
    {
        private int v;

        public MaxlengthAttribute(int v)
        {
            this.v = v;
        }
    }
}