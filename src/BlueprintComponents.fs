module Blueprint.Components 

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.React

open Blueprint.Props

let inline rtEl<'P when 'P :> IBlueprintProp> (a:ComponentClass<'P>) (b:'P list) c = 
    Fable.Helpers.React.from a (keyValueList CaseRules.LowerFirst b |> unbox) c

let Icon = importMember<ComponentClass<IconProps>> "@blueprintjs/core"
let Alert = importMember<ComponentClass<AlertProps>> "@blueprintjs/core"
let Button = importMember<ComponentClass<ButtonProps>> "@blueprintjs/core"
let ButtonGroup = importMember<ComponentClass<ButtonGroupProps>> "@blueprintjs/core"
let Callout = importMember<ComponentClass<CalloutProps>> "@blueprintjs/core"
let Card = importMember<ComponentClass<CardProps>> "@blueprintjs/core"
let Overlay = importMember<ComponentClass<OverlayProps>> "@blueprintjs/core"
let AnchorButton = importMember<ComponentClass<ButtonProps>> "@blueprintjs/core"
let Collapse = importMember<ComponentClass<CollapseProps>> "@blueprintjs/core"
let Popover = importMember<ComponentClass<PopoverProps>> "@blueprintjs/core"
let MenuItem = importMember<ComponentClass<MenuItemProps>> "@blueprintjs/core"
let CollapsibleList = importMember<ComponentClass<CollapsibleListProps>> "@blueprintjs/core"
let Dialog = importMember<ComponentClass<DialogProps>> "@blueprintjs/core"
let Divider = importMember<ComponentClass<DividerProps>> "@blueprintjs/core"
let EditableText = importMember<ComponentClass<EditableTextProps>> "@blueprintjs/core"
let ControlGroup = importMember<ComponentClass<ControlGroupProps>> "@blueprintjs/core"
let Switch = importMember<ComponentClass<ControlProps>> "@blueprintjs/core"
let Radio = importMember<ComponentClass<ControlProps>> "@blueprintjs/core"
let Checkbox = importMember<ComponentClass<ControlProps>> "@blueprintjs/core"
let FileInput = importMember<ComponentClass<FileInputProps>> "@blueprintjs/core"
let FormGroup = importMember<ComponentClass<FormGroupProps>> "@blueprintjs/core"
let InputGroup = importMember<ComponentClass<InputGroupProps>> "@blueprintjs/core"
let NumericInput = importMember<ComponentClass<NumericInputProps>> "@blueprintjs/core"
let RadioGroup = importMember<ComponentClass<RadioGroupProps>> "@blueprintjs/core"
let TextArea = importMember<ComponentClass<TextAreaProps>> "@blueprintjs/core"
let Hotkey = importMember<ComponentClass<HotkeyProps>> "@blueprintjs/core"
let KeyCombo = importMember<ComponentClass<KeyComboProps>> "@blueprintjs/core"
let Hotkeys = importMember<ComponentClass<HotkeysProps>> "@blueprintjs/core"
let MenuDivider = importMember<ComponentClass<MenuDividerProps>> "@blueprintjs/core"
let Menu = importMember<ComponentClass<MenuProps>> "@blueprintjs/core"
let NavbarGroup = importMember<ComponentClass<NavbarGroupProps>> "@blueprintjs/core"
let NavbarHeading = importMember<ComponentClass<NavbarHeadingProps>> "@blueprintjs/core"
let Navbar = importMember<ComponentClass<NavbarProps>> "@blueprintjs/core"
let NonIdealState = importMember<ComponentClass<NonIdealStateProps>> "@blueprintjs/core"
let OverflowList = importMember<ComponentClass<IBlueprintProp>> "@blueprintjs/core" //fix props
let Text = importMember<ComponentClass<TextProps>> "@blueprintjs/core"
let PanelStack = importMember<ComponentClass<PanelStackProps>> "@blueprintjs/core"
let Portal = importMember<ComponentClass<PortalProps>> "@blueprintjs/core"
let ProgressBar = importMember<ComponentClass<ProgressBarProps>> "@blueprintjs/core"
let ResizeSensor = importMember<ComponentClass<ResizeSensorProps>> "@blueprintjs/core"
let MultiSlider = importMember<ComponentClass<MultiSliderProps>> "@blueprintjs/core"
let RangeSlider = importMember<ComponentClass<RangeSliderProps>> "@blueprintjs/core"
let Slider = importMember<ComponentClass<SliderProps>> "@blueprintjs/core"
let Spinner = importMember<ComponentClass<SpinnerProps>> "@blueprintjs/core"
let Tab = importMember<ComponentClass<TabProps>> "@blueprintjs/core"
let Tabs = importMember<ComponentClass<TabsProps>> "@blueprintjs/core"
let Tag = importMember<ComponentClass<TagProps>> "@blueprintjs/core"
let TagInput = importMember<ComponentClass<TagInputProps>> "@blueprintjs/core"
let Toast = importMember<ComponentClass<ToastProps>> "@blueprintjs/core"
let Toaster = importMember<ComponentClass<ToasterProps>> "@blueprintjs/core"
let Tooltip = importMember<ComponentClass<TooltipProps>> "@blueprintjs/core"
// let TreeNode = importMember<ComponentClass<TreeNodeProps>> "@blueprintjs/core"
// let Tree = importMember<ComponentClass<Prop>> "@blueprintjs/core"
let NavbarDivider = importMember<ComponentClass<NavbarDividerProps>> "@blueprintjs/core"


let inline alert props c = rtEl Alert props c

let inline button props c = rtEl Button props c

let inline buttonGroup props c = rtEl ButtonGroup props c

let inline callout props c = rtEl Callout props c


let inline card props c  = rtEl Card props c

let inline overlay props c = rtEl Overlay props c 

let inline anchorButton props c = rtEl AnchorButton props c

let inline  collapse props c = rtEl  Collapse props c
let inline  popover props c = rtEl  Popover props c
let inline  menuItem props c = rtEl  MenuItem props c
let inline  collapsibleList props c = rtEl  CollapsibleList props c
let inline  dialog props c = rtEl  Dialog props c
let inline  divider props c = rtEl  Divider props c
let inline  editableText props c = rtEl  EditableText props c
let inline  controlGroup props c = rtEl  ControlGroup props c
let inline  switch props c = rtEl  Switch props c
let inline  radio props c = rtEl  Radio props c
let inline  checkbox props c = rtEl  Checkbox props c
let inline  fileInput props c = rtEl  FileInput props c
let inline  formGroup props c = rtEl  FormGroup props c
let inline  inputGroup props c = rtEl  InputGroup props c
let inline  numericInput props c = rtEl  NumericInput props c
let inline  radioGroup props c = rtEl  RadioGroup props c
let inline  textArea props c = rtEl  TextArea props c
let inline  hotkey props c = rtEl  Hotkey props c
let inline  keyCombo props c = rtEl  KeyCombo props c
let inline  hotkeys props c = rtEl  Hotkeys props c
let inline  menuDivider props c = rtEl  MenuDivider props c
let inline  menu props c = rtEl  Menu props c
let inline  navbarGroup props c = rtEl  NavbarGroup props c
let inline  navbarHeading props c = rtEl  NavbarHeading props c
let inline  navbar props c = rtEl  Navbar props c
let inline  nonIdealState props c = rtEl  NonIdealState props c
let inline  overflowList props c = rtEl  OverflowList props c
let inline  text props c = rtEl  Text props c
let inline  panelStack props c = rtEl  PanelStack props c
let inline  portal props c = rtEl  Portal props c
let inline  progressBar props c = rtEl  ProgressBar props c
let inline  resizeSensor props c = rtEl  ResizeSensor props c
let inline  multiSlider props c = rtEl  MultiSlider props c
let inline  rangeSlider props c = rtEl  RangeSlider props c
let inline  slider props c = rtEl  Slider props c
let inline  spinner props c = rtEl  Spinner props c
let inline  tab props c = rtEl  Tab props c
let inline  tabs props c = rtEl  Tabs props c
let inline  tag props c = rtEl  Tag props c
let inline  tagInput props c = rtEl  TagInput props c
let inline  toast props c = rtEl  Toast props c
let inline  toaster props c = rtEl  Toaster props c
let inline  tooltip props c = rtEl  Tooltip props c
// let inline  treeNode props c = rtEl  TreeNode props c
// let inline  tree props c = rtEl  Tree props c
let inline  navbarDivider props c = rtEl  NavbarDivider props c
let inline icon props c = rtEl Icon props c 
