using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public ReactiveProperty<string> Text { get; }

        public ReactiveCommand<object> ChangeTextCommand { get; }

        private Models.Model model;

        public ViewAViewModel(Models.Model model)
        {
            Text = model
                .ToReactivePropertyAsSynchronized(m => m.Text.Value)
                .AddTo(disposables);

            ChangeTextCommand = new ReactiveCommand()
                .WithSubscribe(_ => ChangeText())
                .AddTo(disposables);

            this.model = model;
        }

        private void ChangeText()
        {
            model.SetTextTest();
        }

        private System.Reactive.Disposables.CompositeDisposable disposables = new System.Reactive.Disposables.CompositeDisposable();
        public void Dispose()
        {
            disposables.Dispose();
        }
    }
}
