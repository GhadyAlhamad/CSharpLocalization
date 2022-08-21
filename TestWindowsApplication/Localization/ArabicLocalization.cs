using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;

namespace TestWindowsApplication.Localization
{ 
public class ArabicLocalization : GridLocalizer
    {
        public override string Language { get { return "Arabic"; } }
       
        public override string GetLocalizedString(GridStringId id)
        {
            string ret = "";
            
            switch (id)
            {
                case GridStringId.GridGroupPanelText: return "أدرج عنوان العمود هنا للتجميع بواسطته";
                case GridStringId.FindNullPrompt: return "إدخال النص للبحث...";
                case GridStringId.FindControlClearButton: return "مسح";
                case GridStringId.FindControlFindButton: return "بحث";
                case GridStringId.CardViewCaptionFormat: return "  {0} رقم السجل";
                case GridStringId.MenuColumnAutoFilterRowHide: return "إخفاء صف الفلترة التلقائية";
                case GridStringId.MenuColumnAutoFilterRowShow: return "إظهار صف الفلترة التلقائية";
                case GridStringId.MenuColumnAverageSummaryTypeDescription: return "​​متوسط";
                case GridStringId.MenuColumnBandCustomization: return " محدد العمود / باند  ";
                case GridStringId.MenuColumnBestFit: return "العرض الأفضل";
                case GridStringId.MenuColumnBestFitAllColumns: return "العرض الأفضل (كل الأعمدة)";
                case GridStringId.MenuColumnClearAllSorting: return "قم بفرز جميع";
                case GridStringId.MenuColumnClearFilter: return "مسح الفلترة";
                case GridStringId.MenuColumnClearSorting: return "​​إلغاء الفهرسة";
                case GridStringId.MenuColumnColumnCustomization: return "اختيار الأعمدة";
                case GridStringId.MenuColumnConditionalFormatting: return "التنسيق الشرطي";
                case GridStringId.MenuColumnCountSummaryTypeDescription: return "العدد";
                case GridStringId.MenuColumnCustomSummaryTypeDescription: return "​​مخصص";
                case GridStringId.MenuColumnExpressionEditor: return "محرر التعبير...";
                case GridStringId.MenuColumnFilter: return "ممكن الفلترة";
                case GridStringId.MenuColumnFilterEditor: return "مصمم الفلترة";
                case GridStringId.MenuColumnFilterMode: return "وضع التصفية";
                case GridStringId.MenuColumnFilterModeDisplayText: return "عرض النص";
                case GridStringId.MenuColumnFilterModeValue: return "​​قيمة";
                case GridStringId.MenuColumnFindFilterHide: return "إخفاء لوحة البحث";
                case GridStringId.MenuColumnFindFilterShow: return "إظهار لوحة البحث";
                case GridStringId.MenuColumnGroup: return "​​تجميع بواسطة هذا الحقل";
                case GridStringId.MenuColumnGroupBox: return "التجميع بواسطة الصندوق";
                case GridStringId.MenuColumnGroupIntervalDay: return "يوم";
                case GridStringId.MenuColumnGroupIntervalMenu: return "الفاصل الزمني للتجميع";
                case GridStringId.MenuColumnGroupIntervalMonth: return "​​شهر";
                case GridStringId.MenuColumnGroupIntervalNone: return "من دون";
                case GridStringId.MenuColumnGroupIntervalSmart: return "ذكية";
                case GridStringId.MenuColumnGroupIntervalYear: return "سنة";
                case GridStringId.MenuColumnGroupSummaryEditor: return "محرر ملخص المجموعة...";
                case GridStringId.MenuColumnGroupSummarySortFormat: return "{1} قبل '{0}'-{2}";
                case GridStringId.MenuColumnMaxSummaryTypeDescription: return "​​الحد الأقصى";
                case GridStringId.MenuColumnMinSummaryTypeDescription: return "​​الحد الأدنى";
                case GridStringId.MenuColumnRemoveColumn: return "إزالة هذا العمود";
                case GridStringId.MenuColumnResetGroupSummarySort: return "​​مسح ملخص الفرز";
                case GridStringId.MenuColumnShowColumn: return "​​إظهار هذا عمود";
                case GridStringId.MenuColumnSortAscending: return "فهرسة تصاعدي";
                case GridStringId.MenuColumnSortDescending: return "فهرسة تنازلي";
                case GridStringId.MenuColumnSortGroupBySummaryMenu: return "​​فرز بوسطة الملخص";
                case GridStringId.MenuColumnSumSummaryTypeDescription: return "المجموع";
                case GridStringId.MenuGroupPanelHide: return " إخفاء مربع التجميع حسب ";
                case GridStringId.MenuGroupPanelShow: return " إظهار مربع التجميع حسب ";
                     
                default:
                    ret = base.GetLocalizedString(id);
                    break;
            }
            return ret;
        }
    } 
}
