﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Medallion
{
    public class NativeRandomRegressionTest : RandomRegressionTest
    {
        public NativeRandomRegressionTest()
            : base(
                  nexts: new[] { 570869451, 228016717, 63082525, 791561502, 1781384151, 1044764965, 415934392, 841409416, 1173634327, 1737775931 },
                  next10s: new[] { 2, 1, 0, 3, 8, 4, 1, 3, 5, 8 },
                  next100To200s: new[] { 126, 110, 102, 136, 182, 148, 119, 139, 154, 180 },
                  nextBooleans: new[] { true, true, true, false, true, true, false, false, true, true },
                  nextBoolean25s: new[] { false, true, true, false, false, false, true, false, false, false },
                  nextBytes: new byte[] { 203, 77, 29, 30, 215, 37, 184, 136, 23, 59 },
                  nextDoubles: new[] { 0.26583180356111, 0.106178558015348, 0.0293750898118015, 0.36859954817621, 0.82952163733054, 0.486506598762472, 0.193684544504473, 0.391811791989865, 0.546516071793864, 0.809214977458685 },
                  nextDouble10s: new[] { 2.6583180356111, 1.06178558015348, 0.293750898118015, 3.6859954817621, 8.2952163733054, 4.86506598762472, 1.93684544504473, 3.91811791989865, 5.46516071793864, 8.09214977458685 },
                  nextDouble100To200s: new[] { 126.583180356111, 110.617855801535, 102.93750898118, 136.859954817621, 182.952163733054, 148.650659876247, 119.368454450447, 139.181179198986, 154.651607179386, 180.921497745869 },
                  nextGaussians: new[] { -0.302089177899287, -0.292229575195989, 1.28907999392745, -1.23836807936283, 0.203834018017012, -0.722271313129191, 0.203295840934711, 0.356499146331734, 1.41362625236025, 0.23812745495051 },
                  nextInt32s: new[] { -959757747, -1877129954, -1009264347, -1481055352, 1024940859, -1964037035, 658241726, 657192180, 388179835, -616393162 },
                  nextInt64s: new[] { 1953206438597922845, -5110325843915843291, 3071139233307835671, 5867325073402637397, 6961700941319513899, -6353502365035911301, -8400046791653548213, 5846559172326459192, -4205302577595163900, 756671642534525877 },
                  nextSingles: new[] { 0.02647084f, 0.5908554f, 0.7600115f, 0.1807421f, 0.1787695f, 0.2728446f, 0.7916217f, 0.1519094f, 0.9540572f, 0.5795171f })
        {
        }

        protected override Random CreateRandom() => new Random(123456);
    }

    public class JavaRandomRegressionTest : RandomRegressionTest
    {
        public JavaRandomRegressionTest()
            : base(
                  nexts: new[] { 80695311, 477507112, 1723302968, 1096769715, 1946844995, 333710106, 614657224, 900938814, 1748165319, 1871713855 },
                  next10s: new[] { 1, 2, 8, 5, 5, 6, 4, 4, 9, 5 },
                  next100To200s: new[] { 111, 112, 168, 115, 195, 106, 124, 114, 119, 155 },
                  nextBooleans: new[] { false, false, true, true, true, false, false, false, true, true },
                  nextBoolean25s: new[] { true, false, false, false, false, false, true, true, false, false },
                  nextBytes: new byte[] { 31, 81, 113, 102, 134, 53, 144, 124, 143, 127 },
                  nextDoubles: new[] { 0.0375766787284102, 0.802475474934626, 0.906570347478924, 0.28622207670707, 0.814052922600279, 0.567928419878675, 0.000526853696910523, 0.144868717278274, 0.276456002047526, 0.558417928195557 },
                  nextDouble10s: new[] { 0.375766787284102, 8.02475474934626, 9.06570347478924, 2.8622207670707, 8.14052922600279, 5.67928419878675, 0.00526853696910523, 1.44868717278274, 2.76456002047526, 5.58417928195557 },
                  nextDouble100To200s: new[] { 103.757667872841, 180.247547493463, 190.657034747892, 128.622207670707, 181.405292260028, 156.792841987867, 100.052685369691, 114.486871727827, 127.645600204753, 155.841792819556 },
                  nextGaussians: new[] { 0.515493010342488, -0.27105032599248, 1.29988100805167, 0.28115918226825, -1.70014204088578, 0.444291846689743, 1.3051192859527, -1.60589202347456, -2.66092891018521, 0.250022697323862 },
                  nextInt32s: new[] { 161390623, 955014225, -848361359, -2101427866, -401277306, 667420213, 1229314448, 1801877628, -798636657, -551539585 },
                  nextInt64s: new[] { 693167448621079633, -3643684294196543130, -1723472905229564363, 5279865352462170236, -3430118323753309057, -7970313755896301918, 9718723092385624, 2672356380076266151, 5099713240532705732, -8145751493179972455 },
                  nextSingles: new[] { 0.03757668f, 0.2223566f, 0.8024755f, 0.5107232f, 0.9065703f, 0.1553959f, 0.286222f, 0.4195323f, 0.8140529f, 0.8715847f })
        {
        }

        protected override Random CreateRandom() => Rand.CreateJavaRandom(9876543210);
    }

    public class RandomNumberGeneratorRegressionTest : RandomRegressionTest
    {
        public RandomNumberGeneratorRegressionTest()
            // note that the baselines here are similar to JavaRandom but not exactly the same.
            // They are similar because in this test the underlying bytes are provided by JavaRandom. They
            // differ, however, for sequences like NextSingle() and NextBoolean() where this version is able to
            // consume fewer internal bytes per call than the JavaRandom algorithm
            : base(
                  nexts: new[] { 80695311, 477507112, 1723302968, 1096769715, 1946844995, 333710106, 614657224, 900938814, 1748165319, 1871713855 },
                  next10s: new[] { 1, 2, 8, 5, 5, 6, 4, 4, 9, 5 },
                  next100To200s: new[] { 111, 112, 168, 115, 195, 106, 124, 114, 119, 155 },
                  nextBooleans: new[] { false, true, true, false, false, false, true, false, false, false },
                  nextBoolean25s: new[] { true, false, false, false, false, false, true, true, false, false },
                  nextBytes: new byte[] { 31, 81, 113, 102, 134, 53, 144, 124, 143, 127 },
                  nextDoubles: new[] { 0.0375766787284102, 0.802475474934626, 0.906570347478924, 0.28622207670707, 0.814052922600279, 0.567928419878675, 0.000526853696910523, 0.144868717278274, 0.276456002047526, 0.558417928195557 },
                  nextDouble10s: new[] { 0.375766787284102, 8.02475474934626, 9.06570347478924, 2.8622207670707, 8.14052922600279, 5.67928419878675, 0.00526853696910523, 1.44868717278274, 2.76456002047526, 5.58417928195557 },
                  nextDouble100To200s: new[] { 103.757667872841, 180.247547493463, 190.657034747892, 128.622207670707, 181.405292260028, 156.792841987867, 100.052685369691, 114.486871727827, 127.645600204753, 155.841792819556 },
                  nextGaussians: new[] { 0.515493010342488, -0.27105032599248, 1.29988100805167, 0.28115918226825, -1.70014204088578, 0.444291846689743, 1.3051192859527, -1.60589202347456, -2.66092891018521, 0.250022697323862 },
                  nextInt32s: new[] { 161390623, 955014225, -848361359, -2101427866, -401277306, 667420213, 1229314448, 1801877628, -798636657, -551539585 },
                  nextInt64s: new[] { 693167448621079633, -3643684294196543130, -1723472905229564363, 5279865352462170236, -3430118323753309057, -7970313755896301918, 9718723092385624, 2672356380076266151, 5099713240532705732, -8145751493179972455 },
                  nextSingles: new[] { 0.6196308f, 0.3606115f, 0.4422748f, 0.8024755f, 0.7451385f, 0.9942399f, 0.2105725f, 0.1553959f, 0.272851f, 0.4706464f })
        {
        }

        protected override Random CreateRandom() => new TestRandomNumberGenerator().AsRandom();

        private sealed class TestRandomNumberGenerator : RandomNumberGenerator
        {
            private readonly Random random = Rand.CreateJavaRandom(9876543210);
            
            public override void GetBytes(byte[] data)
            {
                this.random.NextBytes(data);
            }
        }
    }
}
