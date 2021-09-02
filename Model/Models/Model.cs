using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Model: BindableBase
    {
        public ReactivePropertySlim<string> Text { get; set; }

        public Model()
        {
            Text = new ReactivePropertySlim<string>()
                .AddTo(disposables);
        }

        public void SetTextTest()
        {
            Text.Value = "テスト";
        }

        private System.Reactive.Disposables.CompositeDisposable disposables = new System.Reactive.Disposables.CompositeDisposable();
        public void Dispose()
        {
            disposables.Dispose();
        }
    }
}
