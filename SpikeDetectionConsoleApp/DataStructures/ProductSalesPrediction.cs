﻿using Microsoft.ML.Data;

namespace SpikeDetection.DataStructures
{
    public class ProductSalesPrediction
    {
        //vector to hold alert,score,p-value values
        [VectorType(3)]
        public double[] Prediction { get; set; }
    }

    public class PopPrediction
    {
        //vector to hold alert,score,p-value values
        [VectorType(6)]
        public double[] Prediction { get; set; }
    }
}
