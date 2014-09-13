using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegexpPracticeApp {
    class RegexpPracticeException:Exception {
        public RegexpPracticeException() { }
        public RegexpPracticeException(string message) : base(message) { }
        public RegexpPracticeException(string message, Exception inner) : base(message, inner) { }
    }
}
