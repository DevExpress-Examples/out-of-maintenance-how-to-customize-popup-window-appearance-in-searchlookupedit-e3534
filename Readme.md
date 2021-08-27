<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128626976/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3534)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/E3534/Form1.cs) (VB: [Form1.vb](./VB/E3534/Form1.vb))
* [Program.cs](./CS/E3534/Program.cs) (VB: [Program.vb](./VB/E3534/Program.vb))
<!-- default file list end -->
# How to customize popup window appearance in SearchLookUpEdit


<p>This example demonstrates how to customize the SearchLookUpEdit popup appearance.<br />
All popup controls inherited from RepositoryItemPopupBase has the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemPopupBase_AppearanceDropDowntopic"><u>AppearanceDropDown</u></a> property that represent the appearance settings used to paint the editor's popup window.</p><p>The <strong>AppeareanceDropDown</strong> property works only for simple popup windows. The popup windows in <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSearchLookUpEdittopic"><u>SearchLookUpEdit</u></a> and <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsGridLookUpEdittopic"><u>GridLookUpEdit</u></a> do not use this property because they has complex layouts. <br />
The <strong>S</strong><strong>earch</strong><strong>Look</strong><strong>U</strong><strong>pEdit</strong> popup window contain <i>Layout</i><i>C</i><i>ontrol</i>. To customize its appearance handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsPopupBaseEdit_Popuptopic"><u>Popup</u></a> event. In this event handler obtain PopupWindow and iterate through its controls to find the required <i>LayoutControl</i>. Then, customize its appearance.<br />
</p>

<br/>


