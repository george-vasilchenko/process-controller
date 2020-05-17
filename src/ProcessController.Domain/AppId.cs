using System;

namespace ProcessController.Domain
{
    public struct AppId : IEquatable<AppId>
    {
        public AppId(Guid value)
        {
            this.Value = value;
        }

        public Guid Value { get; }

        public static bool operator ==(AppId left, AppId right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(AppId left, AppId right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            return obj is AppId id && this.Equals(id);
        }

        public bool Equals(AppId other)
        {
            return this.Value.Equals(other.Value);
        }

        public override int GetHashCode()
        {
            return -1937169414 + this.Value.GetHashCode();
        }
    }
}