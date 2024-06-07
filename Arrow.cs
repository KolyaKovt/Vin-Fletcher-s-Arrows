using ArrowFletchings;
using ArrowHeads;

namespace Arrows
{
    public class Arrow
    {
        private const float GOLD_PER_SENTIMETER_SHAFT = 0.05f;

        public ArrowHead Head { get; }
        public float ShaftLength { get; }
        public ArrowFletching Fletching { get; }

        public Arrow(ArrowHead head, float shaftLength, ArrowFletching fletching)
        {
            Head = head;
            if (shaftLength < 60)
            {
                ShaftLength = 60;
            }
            else if (shaftLength > 100)
            {
                ShaftLength = 100;
            }
            else
            {
                ShaftLength = shaftLength;
            }
            Fletching = fletching;
        }

        public float GetCost()
        {
            float sum = 0;
            sum += (int)Head;
            sum += (int)Fletching;
            sum += ShaftLength * GOLD_PER_SENTIMETER_SHAFT;

            return sum;
        }
    }
}
