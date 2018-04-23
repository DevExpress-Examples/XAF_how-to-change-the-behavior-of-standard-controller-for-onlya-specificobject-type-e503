using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.SystemModule;

namespace WinSolution.Module.Win {
    public class MyWinNewObjectViewController : WinNewObjectViewController {
        protected override void OnAfterConstruction() {
            base.OnAfterConstruction();
        }
        protected override void OnActivated() {
            base.OnActivated();
            if (View.ObjectTypeInfo.Type==typeof(DomainObject1)){
                this.NewObjectAction.Caption = "Add";                
            }
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            if (View.ObjectTypeInfo.Type == typeof(DomainObject1)) {
                this.NewObjectAction.Caption = "New";
            }
        }
    }
}
