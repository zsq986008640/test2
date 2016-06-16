using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItertorPattern
{
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();

    }

    public abstract class Aggregate
    {
        public abstract Iterator CreaetIterator();
    }

    public class ConcreteIterator : Iterator
    {

        private ConcreteAggregate aggregate;
        private int Current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }


        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            Current++;
            if (Current < aggregate.Count)
            {
                ret = aggregate[Current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return Current >= aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return aggregate[Current];
        }

    }

    public class ConcreteIteratorDesc : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;
        public ConcreteIteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            current = aggregate.Count - 1;
        }

        public override object First()
        {
            return aggregate[current];
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if (current >0)
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
           return current<0?true:false;
        }

        public override object CurrentItem()
        {
           return aggregate[current];
        }

    }


    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();

        public override Iterator CreaetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

}
