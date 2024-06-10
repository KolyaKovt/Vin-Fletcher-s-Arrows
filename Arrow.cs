using ArrowFletchings;
using ArrowHeads;

namespace Arrows
{
    public class Arrow
    {
        private const float _goldPerSentimeterShaft = 0.05f;

        public ArrowHead Head { get; }
        public float ShaftLength { get; }
        public ArrowFletching Fletching { get; }

        public Arrow(ArrowHead head, float shaftLength, ArrowFletching fletching)
        {
            Head = head;

            ShaftLength = shaftLength switch
            {
                < 60 => 60,
                > 100 => 100,
                _ => shaftLength
            };

            Fletching = fletching;
        }

        public float GetCost()
        {
            float sum = 0;
            sum += (int)Head;
            sum += (int)Fletching;
            sum += ShaftLength * _goldPerSentimeterShaft;

            return sum;
        }
    }
}
