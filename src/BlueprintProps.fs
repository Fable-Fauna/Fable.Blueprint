module Blueprint.Props

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.JS
open Fable.Import.Browser
open Fable.Import
open Fable.Import.React
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.Popper

type IBlueprintProp = interface end


[<StringEnum>]
type Alignment = 
    | [<CompiledName("center")>] CENTER
    | [<CompiledName("left")>] LEFT
    | [<CompiledName("right")>] RIGHT

[<StringEnum>]
type Boundary =
    | [<CompiledName("start")>] START
    | [<CompiledName("end")>] END

[<StringEnum>]
type Colors =
    | [<CompiledName("#10161A")>] BLACK
    | [<CompiledName("#0E5A8A")>] BLUE1
    | [<CompiledName("#106BA3")>] BLUE2
    | [<CompiledName("#137CBD")>] BLUE3
    | [<CompiledName("#2B95D6")>] BLUE4
    | [<CompiledName("#48AFF0")>] BLUE5
    | [<CompiledName("#1F4B99")>] COBALT1
    | [<CompiledName("#2458B3")>] COBALT2
    | [<CompiledName("#2965CC")>] COBALT3
    | [<CompiledName("#4580E6")>] COBALT4
    | [<CompiledName("#669EFF")>] COBALT5
    | [<CompiledName("#182026")>] DARK_GRAY1
    | [<CompiledName("#202B33")>] DARK_GRAY2
    | [<CompiledName("#293742")>] DARK_GRAY3
    | [<CompiledName("#30404D")>] DARK_GRAY4
    | [<CompiledName("#394B59")>] DARK_GRAY5
    | [<CompiledName("#1D7324")>] FOREST1
    | [<CompiledName("#238C2C")>] FOREST2
    | [<CompiledName("#29A634")>] FOREST3
    | [<CompiledName("#43BF4D")>] FOREST4
    | [<CompiledName("#62D96B")>] FOREST5
    | [<CompiledName("#A67908")>] GOLD1
    | [<CompiledName("#BF8C0A")>] GOLD2
    | [<CompiledName("#D99E0B")>] GOLD3
    | [<CompiledName("#F2B824")>] GOLD4
    | [<CompiledName("#FFC940")>] GOLD5
    | [<CompiledName("#5C7080")>] GRAY1
    | [<CompiledName("#738694")>] GRAY2
    | [<CompiledName("#8A9BA8")>] GRAY3
    | [<CompiledName("#A7B6C2")>] GRAY4
    | [<CompiledName("#BFCCD6")>] GRAY5
    | [<CompiledName("#0A6640")>] GREEN1
    | [<CompiledName("#0D8050")>] GREEN2
    | [<CompiledName("#0F9960")>] GREEN3
    | [<CompiledName("#15B371")>] GREEN4
    | [<CompiledName("#3DCC91")>] GREEN5
    | [<CompiledName("#5642A6")>] INDIGO1
    | [<CompiledName("#634DBF")>] INDIGO2
    | [<CompiledName("#7157D9")>] INDIGO3
    | [<CompiledName("#9179F2")>] INDIGO4
    | [<CompiledName("#AD99FF")>] INDIGO5
    | [<CompiledName("#CED9E0")>] LIGHT_GRAY1
    | [<CompiledName("#D8E1E8")>] LIGHT_GRAY2
    | [<CompiledName("#E1E8ED")>] LIGHT_GRAY3
    | [<CompiledName("#EBF1F5")>] LIGHT_GRAY4
    | [<CompiledName("#F5F8FA")>] LIGHT_GRAY5
    | [<CompiledName("#728C23")>] LIME1
    | [<CompiledName("#87A629")>] LIME2
    | [<CompiledName("#9BBF30")>] LIME3
    | [<CompiledName("#B6D94C")>] LIME4
    | [<CompiledName("#D1F26D")>] LIME5
    | [<CompiledName("#A66321")>] ORANGE1
    | [<CompiledName("#BF7326")>] ORANGE2
    | [<CompiledName("#D9822B")>] ORANGE3
    | [<CompiledName("#F29D49")>] ORANGE4
    | [<CompiledName("#FFB366")>] ORANGE5
    | [<CompiledName("#A82A2A")>] RED1
    | [<CompiledName("#C23030")>] RED2
    | [<CompiledName("#DB3737")>] RED3
    | [<CompiledName("#F55656")>] RED4
    | [<CompiledName("#FF7373")>] RED5
    | [<CompiledName("#A82255")>] ROSE1
    | [<CompiledName("#C22762")>] ROSE2
    | [<CompiledName("#DB2C6F")>] ROSE3
    | [<CompiledName("#F5498B")>] ROSE4
    | [<CompiledName("#FF66A1")>] ROSE5
    | [<CompiledName("#63411E")>] SEPIA1
    | [<CompiledName("#7D5125")>] SEPIA2
    | [<CompiledName("#96622D")>] SEPIA3
    | [<CompiledName("#B07B46")>] SEPIA4
    | [<CompiledName("#C99765")>] SEPIA5
    | [<CompiledName("#008075")>] TURQUOISE1
    | [<CompiledName("#00998C")>] TURQUOISE2
    | [<CompiledName("#00B3A4")>] TURQUOISE3
    | [<CompiledName("#14CCBD")>] TURQUOISE4
    | [<CompiledName("#2EE6D6")>] TURQUOISE5
    | [<CompiledName("#9E2B0E")>] VERMILION1
    | [<CompiledName("#B83211")>] VERMILION2
    | [<CompiledName("#D13913")>] VERMILION3
    | [<CompiledName("#EB532D")>] VERMILION4
    | [<CompiledName("#FF6E4A")>] VERMILION5
    | [<CompiledName("#5C255C")>] VIOLET1
    | [<CompiledName("#752F75")>] VIOLET2
    | [<CompiledName("#8F398F")>] VIOLET3
    | [<CompiledName("#A854A8")>] VIOLET4
    | [<CompiledName("#C274C2")>] VIOLET5
    | [<CompiledName("#FFFFFF")>] WHITE

[<StringEnum>]
type Elevation =
    | [<CompiledName("0")>] ZERO
    | [<CompiledName("1")>] ONE
    | [<CompiledName("2")>] TWO
    | [<CompiledName("3")>] THREE
    | [<CompiledName("4")>] FOUR
    // type Exports =
    //     | RemoveNonHTMLProps of props of RemoveNonHTMLPropsProps * ?invalidProps of ResizeArray<string> * ?shouldMerge of bool -> obj
    // type  RemoveNonHTMLPropsProps =
    //     [<Emit "$0[$1]{{=$2}}">] | Item of key of string -> obj  
    // type HTMLDivProps =
    //     inherit React.HTMLAttributes<HTMLDivElement>
    // type HTMLInputProps =
    //     InputHTMLAttributes<HTMLInputElement>
[<StringEnum>]
type IconName =
| [<CompiledName("none")>] NONE


[<StringEnum>]
type Intent =
| [<CompiledName("none")>] NONE
| [<CompiledName("primary")>] PRIMARY
| [<CompiledName("success")>] SUCCESS
| [<CompiledName("warning")>] WARNING
| [<CompiledName("danger")>] DANGER

type IntentProps =
    | Intent of Intent 
    interface IBlueprintProp

type Props =
    | ClassName of string   
    interface IBlueprintProp  

type ActionProps =
    | Disabled of bool  
    | Icon of U2<IconName, ReactElement>  
    | OnClick of (React.MouseEvent -> unit)  
    | Text of React.ReactNode 
    | Intent of Intent     
    | ClassName of string   
    interface IBlueprintProp

type LinkProps =
    | Href of string  
    | Target of string  
    interface IBlueprintProp

type ControlledProps =
    | DefaultValue of string  
    | OnChange of React.FormEventHandler  
    | Value of string  
    interface IBlueprintProp

type BlueprintProps =
    | Disabled of bool 
    | Label of string 
    | Value of U2<string, float>
    | ClassName of string 
    interface IBlueprintProp

type IconProps =
    | Intent of Intent 
    | ClassName of string 
    | Children of obj  
    | Color of string  
    | Icon of U3<IconName, ReactElement, obj> 
    | IconSize of float  
    | Style of React.CSSProperties  
    | TagName of obj  
    | Title of U2<string, obj>  
    interface IBlueprintProp

type OverlayLifecycleProps =
    | OnClosing of (HTMLElement -> unit)  
    | OnClosed of (HTMLElement -> unit)  
    | OnOpening of (HTMLElement -> unit)  
    | OnOpened of (HTMLElement -> unit)  
    interface IBlueprintProp

type BackdropProps =
    | BackdropClassName of string  
    | BackdropProps of React.HTMLProps<HTMLDivElement>  
    | CanOutsideClickClose of bool  
    | HasBackdrop of bool  
    interface IBlueprintProp

type OverlayableProps =
    | AutoFocus of bool  
    | CanEscapeKeyClose of bool  
    | EnforceFocus of bool  
    | ``Lazy`` of bool  
    | TransitionDuration of float  
    | UsePortal of bool  
    | OnClose of (React.SyntheticEvent-> unit)  
    | OverlayLifecycleProps of OverlayLifecycleProps list
    interface IBlueprintProp

type OverlayProps =
    | BackdropClassName of string  
    | BackdropProps of React.HTMLProps<HTMLDivElement>  
    | CanOutsideClickClose of bool  
    | HasBackdrop of bool  
    | ClassName of string 
    | IsOpen of bool 
    | TransitionName of string  
    | AdditionalBackdropProps of BackdropProps list
    interface IBlueprintProp

type OverlayState =
    { HasEverOpened : bool  }

type  AlertProps =
    | ClassName of string 
    | CanEscapeKeyCancel of bool  
    | CanOutsideClickCancel of bool  
    | CancelButtonText of string  
    | ConfirmButtonText of string  
    | Icon of U2<IconName, ReactElement>  
    | Intent of Intent  
    | IsOpen of bool 
    | Style of React.CSSProperties  
    | TransitionDuration of float  
    | OnCancel of (React.SyntheticEvent-> unit)
    | OnConfirm of (React.SyntheticEvent-> unit)
    | OnClose of bool * (React.SyntheticEvent-> unit)
    | OverlayLifecycleProps of OverlayLifecycleProps list
    interface IBlueprintProp

type BreadCrumbProps = 
    | ActionProps of ActionProps list
    | LinkProps of LinkProps list
// let [<Import("*","@blueprintjs/core/lib/cjs/components/breadcrumbs/breadcrumb")>] Breadcrumb of React.SFC<IBreadcrumbProps> = jsNative

type ButtonProps =
    | Active of bool  
    | AlignText of Alignment  
    | ElementRef of (HTMLElement  -> obj )  
    | Fill of bool  
    | Large of bool  
    | Loading of bool  
    | Minimal of bool  
    | RightIcon of U2<IconName, ReactElement>  
    | Small of bool  
    | ``Type`` of string 
    | ActionProps of ActionProps list
    interface IBlueprintProp 

type ButtonState =
    { IsActive : bool }

type  ButtonGroupProps =
    | ClassName of string 
    | AlignText of Alignment  
    | Fill of bool  
    | Minimal of bool  
    | Large of bool  
    | Vertical of bool  
   // | HtmlDivProps of React.HTMLProps<HTMLDivElement>
    interface IBlueprintProp



type CalloutProps =
    | ClassName of string 
    | Icon of U2<IconName, ReactElement>  
    | Intent of Intent  
    | Title of string  
    interface IBlueprintProp


type CardProps =
    | Elevation of Elevation  
    | Interactive of bool  
    | ClassName of string 
    | OnClick of (React.MouseEvent -> unit)  
    //htmldivprops
    interface IBlueprintProp


type  CollapseProps =
    | ClassName of string 
    | ``Component`` of React.ReactType  
    | IsOpen of bool  
    | KeepChildrenMounted of bool  
    | TransitionDuration of float  
    interface IBlueprintProp

type CollapseState =
    { Height : string 
      AnimationState : AnimationStates }

and [<RequireQualifiedAccess>] AnimationStates =
    | OPEN_START = 0
    | OPENING = 1
    | OPEN = 2
    | CLOSING_START = 3
    | CLOSING = 4
    | CLOSED = 5

type PopoverSharedProps =
    | ClassName of string 
    | CaptureDismiss of bool  
    | DefaultIsOpen of bool  
    | Disabled of bool  
    | HoverCloseDelay of float  
    | HoverOpenDelay of float  
    | InheritDarkTheme of bool  
    | IsOpen of bool  
    | Modifiers of Popper.Modifiers  
    | OnInteraction of (bool -> unit)  
    | OpenOnTargetFocus of bool  
    | PopoverClassName of string  
    | PortalClassName of string  
    | Position of U4<Position, string, string, string>  
    | TargetClassName of string  
    | TargetTagName of obj  
    | UsePortal of bool  
    | WrapperTagName of obj  
    | OverlayableProps of OverlayableProps list
    interface IBlueprintProp

type PopoverInteractionKind =
    obj
type PopoverProps =
    | BackdropProps of React.HTMLProps<HTMLDivElement>  
    | Content of U2<string, ReactElement>  
    | InteractionKind of PopoverInteractionKind  
    | HasBackdrop of bool  
    | Minimal of bool  
    | PopoverRef of (HTMLDivElement  -> unit)  
    | Target of U2<string, ReactElement>  
    | PopoverSharedProps of PopoverSharedProps list
    interface IBlueprintProp

type PopoverState =
    { TransformOrigin : string 
      IsOpen : bool 
      HasDarkParent : bool}

type MenuItemProps =
    | Text of React.ReactNode 
    | Active of bool  
    | Children of React.ReactNode  
    | Disabled of bool  
    | Label of string  
    | LabelElement of React.ReactNode  
    | Multiline of bool  
    | PopoverProps of obj  
    | ShouldDismissPopover of bool 
    | ActionProps of ActionProps list
    | LinkProps of LinkProps list
    interface IBlueprintProp 

type CollapsibleListProps =
    | ClassName of string 
    | DropdownTarget of ReactElement 
    | DropdownProps of PopoverProps  
    | VisibleItemRenderer of (MenuItemProps -> float -> ReactElement) 
    | CollapseFrom of Boundary  
    | VisibleItemClassName of string  
    | VisibleItemCount of float 
    interface IBlueprintProp


// type ContextMenuTargetComponent =

//     | Render of unit -> React.ReactElement<obj > 
//     | RenderContextMenu of e of React.MouseEvent<HTMLElement> -> ReactElement 
//     | OnContextMenuClose of unit -> unit
//     interface IBlueprintProp

type DialogProps =
    | ClassName of string 
    | IsOpen of bool 
    | Icon of U2<IconName, ReactElement>  
    | IsCloseButtonShown of bool  
    | Style of React.CSSProperties  
    | Title of React.ReactNode  
    | TransitionName of string  
    | OverlayableProps of OverlayableProps list
    | BackdropProps of BackdropProps list
    interface IBlueprintProp

type DividerProps =
    | ClassName of string 
    | TagName of obj  
    //htmlprops
    interface IBlueprintProp

type EditableTextProps =
    | ClassName of string 
    | ConfirmOnEnterKey of bool  
    | DefaultValue of string  
    | Disabled of bool  
    | IsEditing of bool  
    | MaxLength of float  
    | MinWidth of float  
    | Multiline of bool  
    | MaxLines of float  
    | MinLines of float  
    | Placeholder of string  
    | SelectAllOnFocus of bool  
    | Value of string  
    | OnCancel of  (string -> unit)
    | OnChange of  (string -> unit)
    | OnConfirm of  (string -> unit)
    | OnEdit of  (string -> unit)
    | Intent of Intent 
    interface IBlueprintProp

type EditableTextState =
    { InputHeight : float  
      InputWidth : float  
      IsEditing : bool  
      LastValue : string  
      Value : string  }

type ControlGroupProps =
    | ClassName of string 
    | Fill of bool  
    | Vertical of bool  
    //htmldivprops
    interface IBlueprintProp

type ControlProps =
    | ClassName of string 
    | AlignIndicator of Alignment  
    | ``Checked`` of bool  
    | Children of React.ReactNode  
    | DefaultChecked of bool  
    | Disabled of bool  
    | InputRef of (HTMLInputElement  -> obj )  
    | ``Inline`` of bool  
    | Label of string  
    | LabelElement of React.ReactNode  
    | Large of bool  
    | OnChange of React.FormEventHandler  
    | TagName of obj  
    //inputprops
    interface IBlueprintProp

type CheckboxProps =
    | DefaultIndeterminate of bool  
    | Indeterminate of bool  
    | ControlProps of ControlProps list
    interface IBlueprintProp

type CheckboxState =
    { Indeterminate : bool }

type FileInputProps =
    | ClassName of string 
    | Disabled of bool  
    | Fill of bool  
    | InputProps of React.HTMLProps<HTMLInputElement>  
    | Large of bool  
    | OnInputChange of React.FormEventHandler  
    | Text of React.ReactNode  
    //labelprops
    interface IBlueprintProp

type FormGroupProps =
    | ClassName of string 
    | Disabled of bool  
    | HelperText of React.ReactNode  
    | ``Inline`` of bool  
    | Label of React.ReactNode  
    | LabelFor of string  
    | LabelInfo of React.ReactNode  
    | Intent of Intent 
    interface IBlueprintProp

type InputGroupProps =
    | ClassName of string 
    | Disabled of bool  
    | InputRef of (HTMLInputElement  -> obj )  
    | LeftIcon of U2<IconName, ReactElement>  
    | Large of bool  
    | Placeholder of string  
    | RightElement of ReactElement  
    | Round of bool  
    | ``Type`` of string  
    | ControlledProps of ControlledProps list
    | Intent of Intent 
    interface IBlueprintProp

type InputGroupState =
    | RightElementWidth of float 

type NumericInputProps =
    | ClassName of string 
    | AllowNumericCharactersOnly of bool  
    | ButtonPosition of U2<obj, string>  
    | ClampValueOnBlur of bool  
    | Disabled of bool  
    | Fill of bool  
    | InputRef of (HTMLInputElement  -> obj )  
    | Large of bool  
    | LeftIcon of U2<IconName, ReactElement>  
    | Placeholder of string  
    | MajorStepSize of float  
    | Max of float  
    | Min of float  
    | MinorStepSize of float  
    | SelectAllOnFocus of bool  
    | SelectAllOnIncrement of bool  
    | StepSize of float  
    | Value of U2<float, string>  
    | OnButtonClick of float * (string -> unit)
    | OnValueChange of  float * (string -> unit)
    | Intent of Intent 
    interface IBlueprintProp

type NumericInputState =
    { IsInputGroupFocused : bool  
      IsButtonGroupFocused : bool  
      ShouldSelectAfterUpdate : bool  
      StepMaxPrecision : float  
      Value : string  }

type RadioGroupProps =
    | ClassName of string 
    | Disabled of bool  
    | ``Inline`` of bool  
    | Label of string  
    | Name of string  
    | OnChange of (React.FormEvent -> unit) 
    | Options of ResizeArray<Props>  
    | SelectedValue of U2<string, float>  
    interface IBlueprintProp

type TextAreaProps =
    | ClassName of string 
    | Intent of Intent 
    //htmltextareaprops
    | Fill of bool  
    | Large of bool  
    | InputRef of (HTMLTextAreaElement  -> obj )  
    interface IBlueprintProp

// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H1 of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H2 of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H3 of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H4 of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H5 of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H6 of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] Blockquote of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] Code of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] Pre of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] Label of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] OL of React.StatelessComponent<obj> = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] UL of React.StatelessComponent<obj> = jsNative
type ElementRefProps<'E> = //import
    abstract elementRef: ('E  -> unit)  with get, set

type HTMLSelectProps =
    //htmlselectprops
    | Disabled of bool  
    | Fill of bool  
    | IconProps of obj  
    | Large of bool  
    | Minimal of bool  
    | Multiple of obj  
    | OnChange of ReactEventHandler  
    | Options of Array<U3<string, float, Props>>  
    | Value of U2<string, float>  
    interface IBlueprintProp

// type  HTMLSelect =
//     inherit React.PureComponent<IHTMLSelectProps>
//     | Render of unit -> ReactElement

type HTMLTableProps =
    | Bordered of bool  
    | Condensed of bool  
    | Interactive of bool  
    | Small of bool  
    | Striped of bool  
    //tableelementprops
    interface IBlueprintProp

// type  HTMLTable =
//     inherit React.PureComponent<IHTMLTableProps>
//     | Render of unit -> ReactElement

type HotkeyProps =
    | ClassName of string 
    | AllowInInput of bool  
    | Combo of string 
    | Disabled of bool  
    | Label of string 
    | ``Global`` of bool  
    | Group of string  
    | PreventDefault of bool  
    | StopPropagation of bool  
    | OnKeyDown of (KeyboardEvent -> obj )
    | OnKeyUp of (KeyboardEvent -> obj )
    interface IBlueprintProp

type KeyComboProps =
    | ClassName of string 
    | Combo of string 
    | Minimal of bool  
    interface IBlueprintProp


// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] KeyCodes of IKeyCodeTable = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] Modifiers of IKeyCodeTable = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] ModifierBitMasks of IKeyCodeReverseTable = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] Aliases of IKeyMap = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] ShiftKeys of IKeyMap = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] parseKeyCombo of (string -> IKeyCombo) = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] getKeyComboString of (KeyboardEvent -> string) = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] getKeyCombo of (KeyboardEvent -> IKeyCombo) = jsNative
// let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] normalizeKeyCombo of (string -> string -> ResizeArray<string>) = jsNative

// type KeyCodeTable =
//     [<Emit "$0[$1]{{=$2}}">] abstract Item of code of float -> string 
// type KeyCodeReverseTable =
//     [<Emit "$0[$1]{{=$2}}">] abstract Item of key of string -> float 
// type KeyMap =
//     [<Emit "$0[$1]{{=$2}}">] abstract Item of key of string -> string 
// type KeyCombo =
//     | Key of string  
//     | Modifiers of float 

type [<StringEnum>] [<RequireQualifiedAccess>] HotkeyScope =
    | [<CompiledName "local">] LOCAL
    | [<CompiledName "global">] GLOBAL

type HotkeyAction =
    | Combo of obj //KeyCombo 
    | Props of HotkeyProps 

type  HotkeysEvents =
    | Scope of obj 
    | Actions of obj 
    | Count of (unit -> float)
    | Clear of (unit -> unit)
    | SetHotkeys of (obj -> unit)
    | HandleKeyDown of (KeyboardEvent -> unit) 
    | HandleKeyUp of (KeyboardEvent -> unit) 
    | InvokeNamedCallbackIfComboRecognized of (obj * obj * obj -> unit)
    | IsScope of (obj -> unit)
    | IsTextInput of (obj -> unit)

// type HotkeysTargetComponent =
//     inherit React.Component
//     | Render of unit -> React.ReactElement<obj > 
//     | RenderHotkeys of unit -> React.ReactElement<IHotkeysProps>

type HotkeysDialogProps =
    | GlobalHotkeysGroup of string  
    interface IBlueprintProp

type HotkeysProps =
    | ClassName of string 
    | TabIndex of float  
    interface IBlueprintProp

type MenuDividerProps =
    | ClassName of string 
    | Children of obj  
    | Title of React.ReactNode  
    interface IBlueprintProp

type MenuProps =
    | ClassName of string 
    | Large of bool  
    | UlRef of (HTMLUListElement  -> obj )  
    interface IBlueprintProp

type NavbarDividerProps =
    | ClassName of string 
    //divprops
    interface IBlueprintProp

type NavbarGroupProps =
    | ClassName of string 
    | Align of Alignment  
    //divprops
    interface IBlueprintProp

type NavbarHeadingProps =
    | ClassName of string 
    //divprops
    interface IBlueprintProp

type NavbarProps =
    | ClassName of string 
    | FixedToTop of bool  
    //divprops
    interface IBlueprintProp

type NonIdealStateProps =
    | ClassName of string 
    | Action of ReactElement  
    | Children of React.ReactNode  
    | Description of React.ReactChild  
    | Icon of U2<IconName, ReactElement>  
    | Title of React.ReactNode  
    interface IBlueprintProp


type OverflowListProps<'T> =
    | ClassName of string 
    | CollapseFrom of Boundary  
    | Items of ResizeArray<'T> 
    | MinVisibleItems of float  
    | ObserveParents of bool  
    | OverflowRenderer of (ResizeArray<'T> -> React.ReactNode) 
    | Style of React.CSSProperties  
    | VisibleItemRenderer of ('T -> float -> React.ReactChild) 
    interface IBlueprintProp

type OverflowListState<'T> =
    { Overflow : ResizeArray<'T> 
      Visible : ResizeArray<'T> }


type TextProps =
    | ClassName of string 
    | Ellipsize of bool  
    | TagName of obj  
    interface IBlueprintProp

type TextState =
    { TextContent : string 
      IsContentOverflowing : bool }

type Panel =
    | ``Component`` of React.Component<obj,obj>
    | Props of obj
    | Title of React.ReactNode  

type PanelProps =
    | ClosePanel of (unit -> unit)
    | OpenPanel of (Panel -> unit)
    interface IBlueprintProp

type PanelStackProps =
    | ClassName of string 
    | InitialPanel of Panel 
    | OnClose of (Panel -> unit)  
    | OnOpen of (Panel -> unit)  
    interface IBlueprintProp

type PanelStackState =
    { Direction : U2<string, string> 
      Stack : ResizeArray<Panel> }

type PortalProps =
    | ClassName of string 
    | OnChildrenMount of (unit -> unit)  
    interface IBlueprintProp

type PortalState =
    { HasMounted : bool } 

type PortalContext =
    { BlueprintPortalClassName : string  } 

type ProgressBarProps =
    | ClassName of string 
    | Animate of bool  
    | Stripes of bool  
    | Value of float  
    | Intent of Intent 
    interface IBlueprintProp

type ResizeEntry =
    | ContentRect of obj //DOMRectReadOnly 
    | Target of Element 

type ResizeSensorProps =
    | OnResize of (ResizeArray<ResizeEntry> -> unit) 
    | ObserveParents of bool  
    interface IBlueprintProp


[<StringEnum>]
type HandleType = 
    | [<CompiledName("full")>] FULL
    | [<CompiledName("start")>] START
    | [<CompiledName("end")>] END

[<StringEnum>]    
type HandleInteractionKind =
    | [<CompiledName("lock")>] LOCK
    | [<CompiledName("push")>] PUSH
    | [<CompiledName("none")>] NONE

type HandleProps =
    | ClassName of string 
    | Value of float 
    | IntentAfter of Intent  
    | IntentBefore of Intent  
    | InteractionKind of HandleInteractionKind  
    | OnChange of (float -> unit)  
    | OnRelease of (float -> unit)  
    | ``Type`` of HandleType  
    interface IBlueprintProp

type ChildrenProps =
    | Children of React.ReactNode  

type SliderBaseProps =
    | ClassName of string 
    | Disabled of bool  
    | LabelStepSize of float  
    | LabelPrecision of float  
    | Max of float  
    | Min of float  
    | ShowTrackFill of bool  
    | StepSize of float  
    | LabelRenderer of U2<bool, (float -> U2<string, ReactElement>)>  
    | Vertical of bool  
    interface IBlueprintProp

type MultiSliderProps =
    | DefaultTrackIntent of Intent  
    | OnChange of (ResizeArray<float> -> unit)
    | OnRelease of (ResizeArray<float> -> unit)
    | SliderBaseProps of SliderBaseProps list
    interface IBlueprintProp

type SliderState =
    { LabelPrecision : float  
      TickSize : float  
      TickSizeRatio : float  }


type NumberRange =
    float * float
type RangeSliderProps =
    | Value of NumberRange  
    | OnChange of (NumberRange -> unit)
    | OnRelease of (NumberRange -> unit)
    | SliderBaseProps of SliderBaseProps list
    interface IBlueprintProp

type SliderProps =
    | InitialValue of float  
    | Value of float  
    | OnChange of (float -> unit)
    | OnRelease of (float -> unit)
    | SliderBaseProps of SliderBaseProps list
    interface IBlueprintProp

type SpinnerProps =
    | ClassName of string 
    | Size of float  
    | TagName of obj  
    | Value of float  
    | Intent of Intent 
    interface IBlueprintProp

type TabId =
    U2<string, float>
[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module TabId =
    let ofString v : TabId = v |> U2.Case1
    let isString (v : TabId) = match v with U2.Case1 _ -> true | _ -> false
    let asString (v : TabId) = match v with U2.Case1 o -> Some o | _ -> None
    let ofFloat v : TabId = v |> U2.Case2
    let isFloat (v : TabId) = match v with U2.Case2 _ -> true | _ -> false
    let asFloat (v : TabId) = match v with U2.Case2 o -> Some o | _ -> None

type TabProps =
    | ClassName of string 
    | Children of React.ReactNode  
    | Disabled of bool  
    | Id of TabId 
    | Panel of ReactElement  
    | Title of React.ReactNode  
    interface IBlueprintProp

//let [<Import("*","@blueprintjs/core/lib/cjs/components/tabs/tabs")>] Expander  = jsNative

type TabsProps =
    | ClassName of string 
    | Animate of bool  
    | DefaultSelectedTabId of TabId  
    | Id of TabId 
    | Large of bool  
    | RenderActiveTabPanelOnly of bool  
    | SelectedTabId of TabId  
    | Vertical of bool  
    | OnChange of (TabId * TabId * React.MouseEvent -> unit)
    interface IBlueprintProp

type TabsState =
    { IndicatorWrapperStyle : React.CSSProperties  
      SelectedTabId : TabId  }

type TagProps =
    | ClassName of string 
    | Active of bool  
    | Icon of U2<IconName, ReactElement>  
    | Interactive of bool  
    | Large of bool  
    | Minimal of bool  
    | Multiline of bool  
    | OnClick of (React.MouseEvent -> unit)  
    | OnRemove of (React.MouseEvent -> TagProps -> unit)  
    | RightIcon of U2<IconName, ReactElement>  
    | Round of bool  
    | Intnet of Intent 
    //htmlspanprops
    interface IBlueprintProp

type TagInputProps =
    | ClassName of string 
    | AddOnBlur of bool  
    | AddOnPaste of bool  
    | Disabled of bool  
    | Fill of bool  
    | InputProps of obj
    | InputRef of (HTMLInputElement  -> unit)  
    | InputValue of string  
    | Large of bool  
    | LeftIcon of U2<IconName, ReactElement>  
    | OnAdd of (ResizeArray<string> -> U2<bool, unit>)  
    | OnChange of (ResizeArray<React.ReactNode> -> U2<bool, unit>)  
    | OnInputChange of React.FormEventHandler  
    | OnKeyDown of (React.KeyboardEvent -> float -> unit)  
    | OnKeyUp of (React.KeyboardEvent -> float -> unit)  
    | OnRemove of (string -> float -> unit)  
    | Placeholder of string  
    | RightElement of ReactElement  
    | Separator of U3<string, RegExp, obj>  
    | TagProps of U2<TagProps, (React.ReactNode -> float -> TagProps)>  
    | Values of ResizeArray<React.ReactNode> 
    interface IBlueprintProp

type TagInputState =
    { ActiveIndex : float  
      InputValue : string  
      IsInputFocused : bool  }

type ToastProps =
    | ClassName of string 
    | Action of obj  
    | Icon of U2<IconName, ReactElement>  
    | Message of U2<string, ReactElement> 
    | OnDismiss of (bool -> unit)  
    | Timeout of float  
    | Intent of Intent 
    interface IBlueprintProp

type Toasts =
    interface end

type ToasterPosition =
    obj

type Toaster =
    | Show of (ToastProps * string -> string)
    | Dismiss of (string -> unit)
    | Clear of (unit -> unit)
    | GetToasts of (unit -> ResizeArray<Toasts>)

type ToasterProps =
    | ClassName of string 
    | AutoFocus of bool  
    | CanEscapeKeyClear of bool  
    | UsePortal of bool  
    | Position of ToasterPosition  
    interface IBlueprintProp

type ToasterState =
    | Toasts of ResizeArray<Toasts> 

type TooltipProps =
    | Content of U2<ReactElement, string> 
    | HoverCloseDelay of float  
    | HoverOpenDelay of float  
    | TransitionDuration of float  
    interface IBlueprintProp
