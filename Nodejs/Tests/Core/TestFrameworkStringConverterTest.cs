﻿//*********************************************************//
//    Copyright (c) Microsoft. All rights reserved.
//    
//    Apache 2.0 License
//    
//    You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//    
//    Unless required by applicable law or agreed to in writing, software 
//    distributed under the License is distributed on an "AS IS" BASIS, 
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or 
//    implied. See the License for the specific language governing 
//    permissions and limitations under the License.
//
//*********************************************************//


using System.ComponentModel;

using Microsoft.NodejsTools.Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudioTools.Project;

namespace NodejsTests {

    [TestClass]
    public class TestFrameworkStringConverterTest {
        [TestMethod, Priority(0), TestCategory("Ignore")]
        public void GetStandardValues_CheckValueSequence() {
            //Arrange
            TestFrameworkStringConverter convert = new TestFrameworkStringConverter();
            //Act
            TypeConverter.StandardValuesCollection values = convert.GetStandardValues(null);
            //Assert
            Assert.AreEqual("ExportRunner", values[0]);
            Assert.AreEqual("mocha", values[1]);
            Assert.AreEqual(2, values.Count);
        }
    }
}
