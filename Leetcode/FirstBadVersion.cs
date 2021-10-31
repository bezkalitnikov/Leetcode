using System;

namespace Leetcode
{
    public class VersionControl
    {
        private readonly bool[] _versions;

        public VersionControl(bool[] versions)
        {
            _versions = versions ?? throw new ArgumentNullException(nameof(versions));
        }

        public bool IsBadVersion(int version)
        {
            return _versions[version - 1];
        }
    }

    public class FirstBadVersionSearcher : VersionControl
    {
        public FirstBadVersionSearcher(bool[] versions) : base(versions)
        {
        }

        public int FirstBadVersion(int n)
        {
            var left = 1;
            var right = n;

            while (left < right)
            {
                var middle = left + (right - left) / 2;

                if (IsBadVersion(middle))
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return left;
        }
    }
}