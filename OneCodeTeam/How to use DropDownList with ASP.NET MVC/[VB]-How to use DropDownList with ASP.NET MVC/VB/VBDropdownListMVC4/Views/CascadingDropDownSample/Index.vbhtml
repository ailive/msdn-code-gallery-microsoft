﻿@ModelType VBDropdownListMVC4.CascadingDropDownSampleModel

@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@section Scripts
    <script src="~/Scripts/CascadingDropDownSample.js"></script>
End Section

<h2>CascadingDropDown Demonstration in ASP.NET MVC 4</h2>
<h3>This sample includes:</h3>
<ul>
    <li>How to create a simple dropdownlist</li>
    <li>How to post data to server when dropdown list selected item changed</li>
    <li>How to implement cascaded DropDownList</li>
    <li>How to update the local section accroding to the item selected</li>
    <li>How to dynamically generate options for dropdown list</li>
</ul>
<table>
    <tr>
        <td>Make</td>
        <td>
            <select id="make" class="size-200">
                <option value="-1">Please select a make</option>
                @For Each make As KeyValuePair(Of String, String) In Model.Makes
                    @<option value="@make.Key">@make.Value</option>
                Next
            </select>
        </td>
    </tr>
    <tr>
        <td>Model</td>
        <td>
            <select id="model" class="size-200" disabled>
                <option value="-1">Please select a model</option>
            </select>
        </td>
    </tr>
    <tr>
        <td>Color</td>
        <td>
            <select id="color" class="size-200" disabled>
                <option value="-1">Please select a color</option>
            </select>
        </td>
    </tr>
</table>

