using Microsoft.ML.Data;

namespace SpikeDetection.DataStructures
{
    public class ProductSalesData
    {
        [LoadColumn(0)]
        public string Month;

        [LoadColumn(1)]
        public float numSales;
    }

    public class PopData
    {
        [LoadColumn(2)]
        public string Time;

        [LoadColumn(3)]
        public float Value;
    }

}
