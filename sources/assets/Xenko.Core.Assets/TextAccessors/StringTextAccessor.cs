// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Xenko.Core;

namespace Xenko.Core.Assets.TextAccessors
{
    [DataContract]
    public class StringTextAccessor : ISerializableTextAccessor
    {
        [DataMember]
        public string Text { get; set; }

        public ITextAccessor Create()
        {
            var result = new DefaultTextAccessor();
            result.Set(Text);
            return result;
        }
    }
}
