using ArrowFletchings;
using ArrowHeads;

namespace Arrows
{
    public class Arrow
    {
        private const float GOLD_PER_SENTIMETER_SHAFT = 0.05f;

        private readonly ArrowHead _head;
        private readonly float _shaftLength;
        private readonly ArrowFletching _fletching;

        public Arrow(ArrowHead head, float shaftLength, ArrowFletching fletching)
        {
            _head = head;
            if (shaftLength < 60)
            {
                _shaftLength = 60;
            }
            else if (shaftLength > 100)
            {
                _shaftLength = 100;
            }
            else
            {
                _shaftLength = shaftLength;
            }
            _fletching = fletching;
        }

        public float GetCost()
        {
            float sum = 0;
            sum += (int)_head;
            sum += (int)_fletching;
            sum += _shaftLength * GOLD_PER_SENTIMETER_SHAFT;

            return sum;
        }
    }
}
