// ts2fable 0.6.1
module rec BlueprintRaw
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

let [<Import("*","@blueprintjs/core/lib/cjs/accessibility/focusStyleManager")>] FocusStyleManager: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract AbstractComponent: AbstractComponentStatic

/// An abstract component that Blueprint components can extend
/// in order to add some common functionality like runtime props validation.
type [<AllowNullLiteral>] AbstractComponent<'P, 'S> =
    inherit React.Component<'P, 'S>
    /// Component displayName should be `public static`. This property exists to prevent incorrect usage. 
    abstract displayName: obj with get, set
    abstract timeoutIds: obj with get, set
    abstract componentWillReceiveProps: nextProps: obj -> unit
    abstract componentWillUnmount: unit -> unit
    /// Set a timeout and remember its ID.
    /// All stored timeouts will be cleared when component unmounts.
    abstract setTimeout: callback: (unit -> unit) * ?timeout: float -> (unit -> unit)
    /// Clear all known timeouts.
    abstract clearTimeouts: (unit -> unit) with get, set
    /// Ensures that the props specified for a component are valid.
    /// Implementations should check that props are valid and usually throw an Error if they are not.
    /// Implementations should not duplicate checks that the type system already guarantees.
    /// 
    /// This method should be used instead of React's
    /// [propTypes](https://facebook.github.io/react/docs/reusable-components.html#prop-validation) feature.
    /// Like propTypes, these runtime checks run only in development mode.
    abstract validateProps: ``_``: obj -> unit

/// An abstract component that Blueprint components can extend
/// in order to add some common functionality like runtime props validation.
type [<AllowNullLiteral>] AbstractComponentStatic =
    [<Emit "new $0($1...)">] abstract Create: ?props: 'P * ?context: obj option -> AbstractComponent<'P, 'S>

type [<AllowNullLiteral>] IExports =
    abstract AbstractPureComponent: AbstractPureComponentStatic

type AbstractPureComponent<'S> =
    AbstractPureComponent<obj, 'S>

/// An abstract component that Blueprint components can extend
/// in order to add some common functionality like runtime props validation.
type [<AllowNullLiteral>] AbstractPureComponent<'P, 'S> =
    inherit React.PureComponent<'P, 'S>
    /// Component displayName should be `public static`. This property exists to prevent incorrect usage. 
    abstract displayName: obj with get, set
    abstract timeoutIds: obj with get, set
    abstract componentWillReceiveProps: nextProps: obj -> unit
    abstract componentWillUnmount: unit -> unit
    /// Set a timeout and remember its ID.
    /// All stored timeouts will be cleared when component unmounts.
    abstract setTimeout: callback: (unit -> unit) * ?timeout: float -> (unit -> unit)
    /// Clear all known timeouts.
    abstract clearTimeouts: (unit -> unit) with get, set
    /// Ensures that the props specified for a component are valid.
    /// Implementations should check that props are valid and usually throw an Error if they are not.
    /// Implementations should not duplicate checks that the type system already guarantees.
    /// 
    /// This method should be used instead of React's
    /// [propTypes](https://facebook.github.io/react/docs/reusable-components.html#prop-validation) feature.
    /// Like propTypes, these runtime checks run only in development mode.
    abstract validateProps: ``_``: obj -> unit

/// An abstract component that Blueprint components can extend
/// in order to add some common functionality like runtime props validation.
type [<AllowNullLiteral>] AbstractPureComponentStatic =
    [<Emit "new $0($1...)">] abstract Create: ?props: 'P * ?context: obj option -> AbstractPureComponent<'P, 'S>
let [<Import("*","@blueprintjs/core/lib/cjs/common/alignment")>] Alignment: obj = jsNative

type Alignment =
    obj
let [<Import("*","@blueprintjs/core/lib/cjs/common/boundary")>] Boundary: obj = jsNative

type Boundary =
    obj
let [<Import("*","@blueprintjs/core/lib/cjs/common/colors")>] Colors: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract IConstructor: IConstructorStatic

/// Generic interface defining constructor types, such as classes. This is used to type the class
/// itself in meta-programming situations such as decorators.
type [<AllowNullLiteral>] IConstructor<'T> =
    interface end

/// Generic interface defining constructor types, such as classes. This is used to type the class
/// itself in meta-programming situations such as decorators.
type [<AllowNullLiteral>] IConstructorStatic =
    [<Emit "new $0($1...)">] abstract Create: [<ParamArray>] args: ResizeArray<obj option> -> IConstructor<'T>
let [<Import("*","@blueprintjs/core/lib/cjs/common/elevation")>] Elevation: obj = jsNative

type Elevation =
    obj
let [<Import("*","@blueprintjs/core/lib/cjs/common/intent")>] Intent: obj = jsNative

type Intent =
    obj
let [<Import("*","@blueprintjs/core/lib/cjs/common/position")>] Position: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract isPositionHorizontal: position: Position -> bool
    abstract isPositionVertical: position: Position -> bool

type Position =
    obj
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ADD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ADD_COLUMN_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ADD_COLUMN_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ADD_ROW_BOTTOM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ADD_ROW_TOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ADD_TO_ARTIFACT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ADD_TO_FOLDER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] AIRPLANE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGN_CENTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGN_JUSTIFY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGN_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGN_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGNMENT_BOTTOM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGNMENT_HORIZONTAL_CENTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGNMENT_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGNMENT_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGNMENT_TOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ALIGNMENT_VERTICAL_CENTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ANNOTATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] APPLICATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] APPLICATIONS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROW_BOTTOM_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROW_BOTTOM_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROW_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROW_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROW_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROW_TOP_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROW_TOP_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROW_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROWS_HORIZONTAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ARROWS_VERTICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ASTERISK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] AUTOMATIC_UPDATES: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BADGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BAN_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BANK_ACCOUNT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BARCODE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BLANK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BLOCKED_PERSON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BOLD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BOOK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BOOKMARK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BOX: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BRIEFCASE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] BUILD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CALCULATOR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CALENDAR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CAMERA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CARET_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CARET_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CARET_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CARET_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CELL_TOWER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHANGES: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHAT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHEVRON_BACKWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHEVRON_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHEVRON_FORWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHEVRON_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHEVRON_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CHEVRON_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CIRCLE_ARROW_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CIRCLE_ARROW_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CIRCLE_ARROW_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CIRCLE_ARROW_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CITATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CLIPBOARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CLOUD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CLOUD_DOWNLOAD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CLOUD_UPLOAD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CODE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CODE_BLOCK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] COG: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] COLLAPSE_ALL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] COLUMN_LAYOUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] COMMENT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] COMPARISON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] COMPASS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] COMPRESSED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CONFIRM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CONSOLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CONTRAST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CONTROL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CREDIT_CARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CROSS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CROWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CURVED_RANGE_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] CUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DASHBOARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DATABASE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DELETE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DELTA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DERIVE_COLUMN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DESKTOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DIAGRAM_TREE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DIRECTION_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DIRECTION_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DISABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOCUMENT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOCUMENT_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOCUMENT_SHARE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOLLAR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOUBLE_CARET_HORIZONTAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOUBLE_CARET_VERTICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOUBLE_CHEVRON_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOUBLE_CHEVRON_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOUBLE_CHEVRON_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOUBLE_CHEVRON_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOUGHNUT_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DOWNLOAD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DRAG_HANDLE_HORIZONTAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DRAG_HANDLE_VERTICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DRAW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DRIVE_TIME: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] DUPLICATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EDIT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EJECT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ENDORSED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ENVELOPE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ERASER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ERROR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EURO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EXCHANGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EXCLUDE_ROW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EXPAND_ALL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EXPORT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EYE_OFF: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EYE_ON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] EYE_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FAST_BACKWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FAST_FORWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FEED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FEED_SUBSCRIBED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FILM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FILTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FILTER_KEEP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FILTER_LIST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FILTER_REMOVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FLAG: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FLAME: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FLASH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FLOPPY_DISK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FLOWS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FOLDER_CLOSE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FOLDER_NEW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FOLDER_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FOLDER_SHARED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FOLDER_SHARED_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FOLLOWER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FOLLOWING: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FONT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FORK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FORM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FULL_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FULL_STACKED_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FULLSCREEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] FUNCTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GANTT_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GEOLOCATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GEOSEARCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GIT_BRANCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GIT_COMMIT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GIT_MERGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GIT_NEW_BRANCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GIT_PULL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GIT_PUSH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GIT_REPO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GLASS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GLOBE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GLOBE_NETWORK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GRAPH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GRAPH_REMOVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GRID: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GRID_VIEW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GROUP_OBJECTS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] GROUPED_BAR_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HAND: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HAND_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HAND_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HAND_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HAND_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HEADER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HEADER_ONE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HEADER_TWO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HEADSET: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HEART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HEART_BROKEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HEAT_GRID: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HEATMAP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HELP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HELPER_MANAGEMENT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HIGHLIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HISTORY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HOME: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HORIZONTAL_BAR_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HORIZONTAL_BAR_CHART_ASC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HORIZONTAL_BAR_CHART_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] HORIZONTAL_DISTRIBUTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ID_NUMBER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] IMAGE_ROTATE_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] IMAGE_ROTATE_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] IMPORT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] INBOX: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] INFO_SIGN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] INNER_JOIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] INSERT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] INTERSECTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] IP_ADDRESS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ISSUE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ISSUE_CLOSED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ISSUE_NEW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ITALIC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] JOIN_TABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_BACKSPACE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_COMMAND: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_CONTROL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_DELETE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_ENTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_ESCAPE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_OPTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_SHIFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KEY_TAB: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] KNOWN_VEHICLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LABEL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYERS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_AUTO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_BALLOON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_GRID: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_GROUP_BY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_HIERARCHY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_LINEAR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_SKEW_GRID: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LAYOUT_SORTED_CLUSTERS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LEFT_JOIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LIGHTBULB: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LINK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LIST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LIST_DETAIL_VIEW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LOCATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LOCK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LOG_IN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] LOG_OUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MANUAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MANUALLY_ENTERED_DATA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MAP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MAP_CREATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MAP_MARKER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MAXIMIZE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MEDIA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MENU: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MENU_CLOSED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MENU_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MERGE_COLUMNS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MERGE_LINKS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MINIMIZE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MINUS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MOBILE_PHONE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MOBILE_VIDEO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MOON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MORE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MOUNTAIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MOVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MUGSHOT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MULTI_SELECT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] MUSIC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NEW_GRID_ITEM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NEW_LINK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NEW_OBJECT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NEW_PERSON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NEW_PRESCRIPTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NEW_TEXT_BOX: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NINJA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NOTIFICATIONS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NOTIFICATIONS_UPDATED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NUMBERED_LIST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] NUMERICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] OFFICE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] OFFLINE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] OIL_FIELD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ONE_COLUMN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] OUTDATED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PAGE_LAYOUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PANEL_STATS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PANEL_TABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PAPERCLIP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PARAGRAPH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PATH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PATH_SEARCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PAUSE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PEOPLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PERCENTAGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PERSON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PHONE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PIE_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PIVOT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PIVOT_TABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PLAY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PLUS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] POLYGON_FILTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] POWER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PREDICTIVE_ANALYSIS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PRESCRIPTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PRESENTATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PRINT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PROJECTS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PROPERTIES: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PROPERTY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PUBLISH_FUNCTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] PULSE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] RANDOM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] RECORD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REDO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REFRESH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REGRESSION_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REMOVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REMOVE_COLUMN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REMOVE_COLUMN_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REMOVE_COLUMN_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REMOVE_ROW_BOTTOM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REMOVE_ROW_TOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] REPEAT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] RESOLVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] RIG: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] RIGHT_JOIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] RING: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ROTATE_DOCUMENT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ROTATE_PAGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SATELLITE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SAVED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SCATTER_PLOT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SEARCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SEARCH_AROUND: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SEARCH_TEMPLATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SEARCH_TEXT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SEGMENTED_CONTROL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SELECT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SELECTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SEND_TO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SEND_TO_GRAPH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SEND_TO_MAP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SERIES_ADD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SERIES_CONFIGURATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SERIES_DERIVED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SERIES_FILTERED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SERIES_SEARCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SETTINGS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SHARE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SHIELD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SHOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SHOPPING_CART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SIM_CARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SLASH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SMALL_CROSS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SMALL_MINUS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SMALL_PLUS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SMALL_TICK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SNOWFLAKE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SOCIAL_MEDIA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SORT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SORT_ALPHABETICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SORT_ALPHABETICAL_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SORT_ASC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SORT_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SORT_NUMERICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SORT_NUMERICAL_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SPLIT_COLUMNS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SQUARE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STACKED_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STAR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STAR_EMPTY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STEP_BACKWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STEP_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STEP_FORWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STRIKETHROUGH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] STYLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SWAP_HORIZONTAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SWAP_VERTICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SYMBOL_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SYMBOL_CROSS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SYMBOL_DIAMOND: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SYMBOL_SQUARE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SYMBOL_TRIANGLE_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] SYMBOL_TRIANGLE_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TAG: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TAKE_ACTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TAXI: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TEXT_HIGHLIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TH_DERIVED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TH_LIST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] THUMBS_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] THUMBS_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TICK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TICK_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TIME: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TIMELINE_AREA_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TIMELINE_BAR_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TIMELINE_EVENTS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TIMELINE_LINE_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TINT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TORCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TRAIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TRANSLATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TRASH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TREE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TRENDING_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TRENDING_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] TWO_COLUMNS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UNDERLINE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UNDO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UNGROUP_OBJECTS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UNKNOWN_VEHICLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UNLOCK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UNPIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UNRESOLVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UPDATED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] UPLOAD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] USER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] VARIABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] VERTICAL_BAR_CHART_ASC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] VERTICAL_BAR_CHART_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] VERTICAL_DISTRIBUTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] VIDEO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] VOLUME_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] VOLUME_OFF: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] VOLUME_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] WALK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] WARNING_SIGN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] WATERFALL_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] WIDGET: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] WIDGET_BUTTON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] WIDGET_FOOTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] WIDGET_HEADER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] WRENCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ZOOM_IN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ZOOM_OUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconContents")>] ZOOM_TO_FIT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ADD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ADD_COLUMN_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ADD_COLUMN_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ADD_ROW_BOTTOM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ADD_ROW_TOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ADD_TO_ARTIFACT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ADD_TO_FOLDER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] AIRPLANE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGN_CENTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGN_JUSTIFY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGN_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGN_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGNMENT_BOTTOM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGNMENT_HORIZONTAL_CENTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGNMENT_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGNMENT_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGNMENT_TOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ALIGNMENT_VERTICAL_CENTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ANNOTATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] APPLICATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] APPLICATIONS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROW_BOTTOM_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROW_BOTTOM_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROW_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROW_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROW_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROW_TOP_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROW_TOP_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROW_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROWS_HORIZONTAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ARROWS_VERTICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ASTERISK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] AUTOMATIC_UPDATES: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BADGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BAN_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BANK_ACCOUNT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BARCODE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BLANK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BLOCKED_PERSON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BOLD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BOOK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BOOKMARK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BOX: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BRIEFCASE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] BUILD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CALCULATOR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CALENDAR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CAMERA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CARET_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CARET_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CARET_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CARET_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CELL_TOWER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHANGES: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHAT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHEVRON_BACKWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHEVRON_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHEVRON_FORWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHEVRON_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHEVRON_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CHEVRON_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CIRCLE_ARROW_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CIRCLE_ARROW_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CIRCLE_ARROW_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CIRCLE_ARROW_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CITATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CLIPBOARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CLOUD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CLOUD_DOWNLOAD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CLOUD_UPLOAD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CODE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CODE_BLOCK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] COG: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] COLLAPSE_ALL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] COLUMN_LAYOUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] COMMENT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] COMPARISON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] COMPASS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] COMPRESSED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CONFIRM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CONSOLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CONTRAST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CONTROL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CREDIT_CARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CROSS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CROWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CURVED_RANGE_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] CUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DASHBOARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DATABASE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DELETE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DELTA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DERIVE_COLUMN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DESKTOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DIAGRAM_TREE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DIRECTION_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DIRECTION_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DISABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOCUMENT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOCUMENT_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOCUMENT_SHARE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOLLAR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOUBLE_CARET_HORIZONTAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOUBLE_CARET_VERTICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOUBLE_CHEVRON_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOUBLE_CHEVRON_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOUBLE_CHEVRON_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOUBLE_CHEVRON_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOUGHNUT_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DOWNLOAD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DRAG_HANDLE_HORIZONTAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DRAG_HANDLE_VERTICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DRAW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DRIVE_TIME: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] DUPLICATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EDIT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EJECT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ENDORSED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ENVELOPE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ERASER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ERROR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EURO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EXCHANGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EXCLUDE_ROW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EXPAND_ALL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EXPORT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EYE_OFF: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EYE_ON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] EYE_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FAST_BACKWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FAST_FORWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FEED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FEED_SUBSCRIBED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FILM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FILTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FILTER_KEEP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FILTER_LIST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FILTER_REMOVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FLAG: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FLAME: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FLASH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FLOPPY_DISK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FLOWS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FOLDER_CLOSE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FOLDER_NEW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FOLDER_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FOLDER_SHARED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FOLDER_SHARED_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FOLLOWER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FOLLOWING: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FONT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FORK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FORM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FULL_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FULL_STACKED_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FULLSCREEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] FUNCTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GANTT_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GEOLOCATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GEOSEARCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GIT_BRANCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GIT_COMMIT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GIT_MERGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GIT_NEW_BRANCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GIT_PULL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GIT_PUSH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GIT_REPO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GLASS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GLOBE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GLOBE_NETWORK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GRAPH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GRAPH_REMOVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GRID: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GRID_VIEW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GROUP_OBJECTS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] GROUPED_BAR_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HAND: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HAND_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HAND_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HAND_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HAND_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HEADER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HEADER_ONE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HEADER_TWO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HEADSET: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HEART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HEART_BROKEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HEAT_GRID: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HEATMAP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HELP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HELPER_MANAGEMENT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HIGHLIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HISTORY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HOME: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HORIZONTAL_BAR_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HORIZONTAL_BAR_CHART_ASC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HORIZONTAL_BAR_CHART_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] HORIZONTAL_DISTRIBUTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ID_NUMBER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] IMAGE_ROTATE_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] IMAGE_ROTATE_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] IMPORT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] INBOX: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] INFO_SIGN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] INNER_JOIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] INSERT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] INTERSECTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] IP_ADDRESS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ISSUE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ISSUE_CLOSED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ISSUE_NEW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ITALIC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] JOIN_TABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_BACKSPACE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_COMMAND: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_CONTROL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_DELETE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_ENTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_ESCAPE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_OPTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_SHIFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KEY_TAB: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] KNOWN_VEHICLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LABEL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYERS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_AUTO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_BALLOON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_GRID: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_GROUP_BY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_HIERARCHY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_LINEAR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_SKEW_GRID: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LAYOUT_SORTED_CLUSTERS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LEFT_JOIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LIGHTBULB: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LINK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LIST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LIST_DETAIL_VIEW: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LOCATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LOCK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LOG_IN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] LOG_OUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MANUAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MANUALLY_ENTERED_DATA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MAP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MAP_CREATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MAP_MARKER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MAXIMIZE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MEDIA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MENU: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MENU_CLOSED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MENU_OPEN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MERGE_COLUMNS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MERGE_LINKS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MINIMIZE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MINUS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MOBILE_PHONE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MOBILE_VIDEO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MOON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MORE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MOUNTAIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MOVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MUGSHOT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MULTI_SELECT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] MUSIC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NEW_GRID_ITEM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NEW_LINK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NEW_OBJECT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NEW_PERSON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NEW_PRESCRIPTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NEW_TEXT_BOX: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NINJA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NOTIFICATIONS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NOTIFICATIONS_UPDATED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NUMBERED_LIST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] NUMERICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] OFFICE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] OFFLINE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] OIL_FIELD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ONE_COLUMN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] OUTDATED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PAGE_LAYOUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PANEL_STATS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PANEL_TABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PAPERCLIP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PARAGRAPH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PATH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PATH_SEARCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PAUSE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PEOPLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PERCENTAGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PERSON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PHONE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PIE_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PIVOT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PIVOT_TABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PLAY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PLUS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] POLYGON_FILTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] POWER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PREDICTIVE_ANALYSIS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PRESCRIPTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PRESENTATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PRINT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PROJECTS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PROPERTIES: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PROPERTY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PUBLISH_FUNCTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] PULSE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] RANDOM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] RECORD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REDO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REFRESH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REGRESSION_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REMOVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REMOVE_COLUMN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REMOVE_COLUMN_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REMOVE_COLUMN_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REMOVE_ROW_BOTTOM: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REMOVE_ROW_TOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] REPEAT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] RESOLVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] RIG: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] RIGHT_JOIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] RING: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ROTATE_DOCUMENT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ROTATE_PAGE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SATELLITE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SAVED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SCATTER_PLOT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SEARCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SEARCH_AROUND: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SEARCH_TEMPLATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SEARCH_TEXT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SEGMENTED_CONTROL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SELECT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SELECTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SEND_TO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SEND_TO_GRAPH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SEND_TO_MAP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SERIES_ADD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SERIES_CONFIGURATION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SERIES_DERIVED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SERIES_FILTERED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SERIES_SEARCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SETTINGS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SHARE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SHIELD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SHOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SHOPPING_CART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SIM_CARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SLASH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SMALL_CROSS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SMALL_MINUS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SMALL_PLUS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SMALL_TICK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SNOWFLAKE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SOCIAL_MEDIA: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SORT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SORT_ALPHABETICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SORT_ALPHABETICAL_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SORT_ASC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SORT_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SORT_NUMERICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SORT_NUMERICAL_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SPLIT_COLUMNS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SQUARE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STACKED_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STAR: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STAR_EMPTY: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STEP_BACKWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STEP_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STEP_FORWARD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STOP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STRIKETHROUGH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] STYLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SWAP_HORIZONTAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SWAP_VERTICAL: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SYMBOL_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SYMBOL_CROSS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SYMBOL_DIAMOND: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SYMBOL_SQUARE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SYMBOL_TRIANGLE_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] SYMBOL_TRIANGLE_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TAG: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TAKE_ACTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TAXI: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TEXT_HIGHLIGHT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TH_DERIVED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TH_LIST: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] THUMBS_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] THUMBS_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TICK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TICK_CIRCLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TIME: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TIMELINE_AREA_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TIMELINE_BAR_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TIMELINE_EVENTS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TIMELINE_LINE_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TINT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TORCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TRAIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TRANSLATE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TRASH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TREE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TRENDING_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TRENDING_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] TWO_COLUMNS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UNDERLINE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UNDO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UNGROUP_OBJECTS: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UNKNOWN_VEHICLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UNLOCK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UNPIN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UNRESOLVE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UPDATED: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] UPLOAD: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] USER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] VARIABLE: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] VERTICAL_BAR_CHART_ASC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] VERTICAL_BAR_CHART_DESC: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] VERTICAL_DISTRIBUTION: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] VIDEO: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] VOLUME_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] VOLUME_OFF: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] VOLUME_UP: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] WALK: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] WARNING_SIGN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] WATERFALL_CHART: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] WIDGET: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] WIDGET_BUTTON: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] WIDGET_FOOTER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] WIDGET_HEADER: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] WRENCH: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ZOOM_IN: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ZOOM_OUT: obj = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconNames")>] ZOOM_TO_FIT: obj = jsNative
module IconNames = __generated_iconNames

type IconName =
    obj
type IconName = ___iconName.IconName
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconSvgPaths")>] IconSvgPaths16: Record<IconName, ResizeArray<string>> = jsNative
let [<Import("*","@blueprintjs/icons/lib/esm/generated/iconSvgPaths")>] IconSvgPaths20: Record<IconName, ResizeArray<string>> = jsNative
type IconName = @blueprintjs_icons.IconName
type Intent = __intent.Intent
let [<Import("*","@blueprintjs/core/lib/cjs/common/props")>] DISPLAYNAME_PREFIX: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Typically applied to HTMLElements to filter out blacklisted props. When applied to a Component,
    /// can filter props from being passed down to the children. Can also filter by a combined list of
    /// supplied prop keys and the blacklist (only appropriate for HTMLElements).</summary>
    /// <param name="props">The original props object to filter down.</param>
    /// <param name="invalidProps">If supplied, overwrites the default blacklist.</param>
    /// <param name="shouldMerge">If true, will merge supplied invalidProps and blacklist together.</param>
    abstract removeNonHTMLProps: props: RemoveNonHTMLPropsProps * ?invalidProps: ResizeArray<string> * ?shouldMerge: bool -> obj

type [<AllowNullLiteral>] RemoveNonHTMLPropsProps =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type HTMLDivProps =
    React.HTMLAttributes<HTMLDivElement>

type HTMLInputProps =
    React.InputHTMLAttributes<HTMLInputElement>

/// A shared base interface for all Blueprint component props.
type [<AllowNullLiteral>] IProps =
    /// A space-delimited list of class names to pass along to a child element. 
    abstract className: string option with get, set

type [<AllowNullLiteral>] IIntentProps =
    /// Visual intent color to apply to element. 
    abstract intent: Intent option with get, set

/// Interface for a clickable action, such as a button or menu item.
/// These props can be spready directly to a `<Button>` or `<MenuItem>` element.
type [<AllowNullLiteral>] IActionProps =
    inherit IIntentProps
    inherit IProps
    /// Whether this action is non-interactive. 
    abstract disabled: bool option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render before the text. 
    abstract icon: U2<IconName, JSX.Element> option with get, set
    /// Click event handler. 
    abstract onClick: (React.MouseEvent<HTMLElement> -> unit) option with get, set
    /// Action text. Can be any single React renderable. 
    abstract text: React.ReactNode option with get, set

/// Interface for a link, with support for customizing target window. 
type [<AllowNullLiteral>] ILinkProps =
    /// Link URL. 
    abstract href: string option with get, set
    /// Link target attribute. Use `"_blank"` to open in a new window. 
    abstract target: string option with get, set

/// Interface for a controlled input. 
type [<AllowNullLiteral>] IControlledProps =
    /// Initial value of the input, for uncontrolled usage. 
    abstract defaultValue: string option with get, set
    /// Change event handler. Use `event.target.value` for new value. 
    abstract onChange: React.FormEventHandler<HTMLElement> option with get, set
    /// Form value of the input, for controlled usage. 
    abstract value: string option with get, set

/// An interface for an option in a list, such as in a `<select>` or `RadioGroup`.
/// These props can be spread directly to an `<option>` or `<Radio>` element.
type [<AllowNullLiteral>] IOptionProps =
    inherit IProps
    /// Whether this option is non-interactive. 
    abstract disabled: bool option with get, set
    /// Label text for this option. If omitted, `value` is used as the label. 
    abstract label: string option with get, set
    /// Value of this option. 
    abstract value: U2<string, float> with get, set
type Alignment = __alignment.Alignment
type Elevation = __elevation.Elevation
type Intent = __intent.Intent
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ACTIVE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ALIGN_LEFT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ALIGN_RIGHT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CONDENSED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DARK: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DISABLED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FILL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FIXED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FIXED_TOP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INLINE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INTERACTIVE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] LARGE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] LOADING: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MINIMAL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MULTILINE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ROUND: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SMALL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] VERTICAL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ELEVATION_0: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ELEVATION_1: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ELEVATION_2: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ELEVATION_3: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ELEVATION_4: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INTENT_PRIMARY: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INTENT_SUCCESS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INTENT_WARNING: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INTENT_DANGER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FOCUS_DISABLED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] UI_TEXT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] RUNNING_TEXT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MONOSPACE_TEXT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TEXT_LARGE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TEXT_SMALL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TEXT_MUTED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TEXT_DISABLED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TEXT_OVERFLOW_ELLIPSIS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BLOCKQUOTE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CODE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CODE_BLOCK: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HEADING: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] LIST: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] LIST_UNSTYLED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] RTL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ALERT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ALERT_BODY: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ALERT_CONTENTS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ALERT_FOOTER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BREADCRUMB: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BREADCRUMB_CURRENT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BREADCRUMBS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BREADCRUMBS_COLLAPSED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BUTTON: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BUTTON_GROUP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BUTTON_SPINNER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] BUTTON_TEXT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CALLOUT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CALLOUT_ICON: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CARD: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] COLLAPSE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] COLLAPSE_BODY: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] COLLAPSIBLE_LIST: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CONTEXT_MENU: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CONTEXT_MENU_POPOVER_TARGET: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CONTROL_GROUP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DIALOG: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DIALOG_CONTAINER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DIALOG_BODY: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DIALOG_CLOSE_BUTTON: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DIALOG_FOOTER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DIALOG_FOOTER_ACTIONS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DIALOG_HEADER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] DIVIDER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] EDITABLE_TEXT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] EDITABLE_TEXT_CONTENT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] EDITABLE_TEXT_EDITING: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] EDITABLE_TEXT_INPUT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] EDITABLE_TEXT_PLACEHOLDER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FLEX_EXPANDER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HTML_SELECT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SELECT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HTML_TABLE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HTML_TABLE_STRIPED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HTML_TABLE_BORDERED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INPUT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INPUT_GHOST: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INPUT_GROUP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] INPUT_ACTION: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CONTROL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CONTROL_INDICATOR: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] CHECKBOX: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] RADIO: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SWITCH: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FILE_INPUT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FILE_UPLOAD_INPUT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] KEY: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] KEY_COMBO: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MODIFIER_KEY: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HOTKEY: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HOTKEY_LABEL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HOTKEY_COLUMN: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] HOTKEY_DIALOG: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] LABEL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FORM_GROUP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FORM_CONTENT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] FORM_HELPER_TEXT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MENU: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MENU_ITEM: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MENU_ITEM_LABEL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MENU_SUBMENU: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MENU_DIVIDER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] MENU_HEADER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] NAVBAR: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] NAVBAR_GROUP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] NAVBAR_HEADING: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] NAVBAR_DIVIDER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] NON_IDEAL_STATE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] NON_IDEAL_STATE_VISUAL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] NUMERIC_INPUT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] OVERFLOW_LIST: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] OVERFLOW_LIST_SPACER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] OVERLAY: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] OVERLAY_BACKDROP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] OVERLAY_CONTENT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] OVERLAY_INLINE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] OVERLAY_OPEN: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] OVERLAY_SCROLL_CONTAINER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PANEL_STACK: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PANEL_STACK_HEADER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PANEL_STACK_HEADER_BACK: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PANEL_STACK_VIEW: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_ARROW: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_BACKDROP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_CONTENT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_CONTENT_SIZING: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_DISMISS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_DISMISS_OVERRIDE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_OPEN: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_TARGET: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] POPOVER_WRAPPER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TRANSITION_CONTAINER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PROGRESS_BAR: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PROGRESS_METER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PROGRESS_NO_STRIPES: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PROGRESS_NO_ANIMATION: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] PORTAL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SKELETON: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SLIDER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SLIDER_AXIS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SLIDER_HANDLE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SLIDER_LABEL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SLIDER_TRACK: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SLIDER_PROGRESS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] START: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] END: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SPINNER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SPINNER_ANIMATION: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SPINNER_HEAD: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SPINNER_NO_SPIN: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] SPINNER_TRACK: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAB: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAB_INDICATOR: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAB_INDICATOR_WRAPPER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAB_LIST: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAB_PANEL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TABS: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAG: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAG_REMOVE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAG_INPUT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAG_INPUT_ICON: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TAG_INPUT_VALUES: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TOAST: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TOAST_CONTAINER: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TOAST_MESSAGE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TOOLTIP: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TOOLTIP_INDICATOR: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_CARET: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_CARET_CLOSED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_CARET_NONE: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_CARET_OPEN: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_CONTENT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_EXPANDED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_ICON: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_LABEL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_LIST: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_SECONDARY_LABEL: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_NODE_SELECTED: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] TREE_ROOT: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ICON: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ICON_STANDARD: string = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/classes")>] ICON_LARGE: string = jsNative

type [<AllowNullLiteral>] IExports =
    /// Returns the namespace prefix for all Blueprint CSS classes.
    /// Customize this namespace at build time with the `process.env.BLUEPRINT_NAMESPACE` environment variable.
    abstract getClassNamespace: unit -> string
    /// Return CSS class for alignment. 
    abstract alignmentClass: alignment: Alignment -> string
    abstract elevationClass: elevation: Elevation -> string
    /// Returns CSS class for icon name. 
    abstract iconClass: ?iconName: string -> string
    /// Return CSS class for intent. 
    abstract intentClass: ?intent: Intent -> string
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] BACKSPACE: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] TAB: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] ENTER: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] SHIFT: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] ESCAPE: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] SPACE: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] ARROW_LEFT: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] ARROW_UP: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] ARROW_RIGHT: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] ARROW_DOWN: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/common/keys")>] DELETE: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// Returns true if the arrays are equal. Elements will be shallowly compared by
    /// default, or they will be compared using the custom `compare` function if one
    /// is provided.
    abstract arraysEqual: arrA: ResizeArray<obj option> * arrB: ResizeArray<obj option> * ?compare: (obj option -> obj option -> bool) -> bool
    /// Shallow comparison between objects. If `keys` is provided, just that subset
    /// of keys will be compared; otherwise, all keys will be compared.
    abstract shallowCompareKeys: objA: 'T * objB: 'T * ?keys: U2<IKeyBlacklist<'T>, IKeyWhitelist<'T>> -> bool
    /// Deep comparison between objects. If `keys` is provided, just that subset of
    /// keys will be compared; otherwise, all keys will be compared.
    abstract deepCompareKeys: objA: obj option * objB: obj option * ?keys: ResizeArray<string> -> bool
    /// Returns a descriptive object for each key whose values are shallowly unequal
    /// between two provided objects. Useful for debugging shouldComponentUpdate.
    abstract getShallowUnequalKeyValues: objA: 'T * objB: 'T * ?keys: U2<IKeyBlacklist<'T>, IKeyWhitelist<'T>> -> ResizeArray<obj>
    /// Returns a descriptive object for each key whose values are deeply unequal
    /// between two provided objects. Useful for debugging shouldComponentUpdate.
    abstract getDeepUnequalKeyValues: ?objA: 'T * ?objB: 'T * ?keys: Array<obj> -> ResizeArray<obj>

type [<AllowNullLiteral>] IKeyWhitelist<'T> =
    abstract ``include``: Array<obj> with get, set

type [<AllowNullLiteral>] IKeyBlacklist<'T> =
    abstract exclude: Array<obj> with get, set

type [<AllowNullLiteral>] IExports =
    /// Returns whether `process.env.NODE_ENV` exists and equals `env`. 
    abstract isNodeEnv: env: string -> bool
    /// Returns whether the value is a function. Acts as a type guard. 
    abstract isFunction: value: obj option -> bool
    /// Returns true if `node` is null/undefined, false, empty string, or an array
    /// composed of those. If `node` is an array, only one level of the array is
    /// checked, for performance reasons.
    abstract isReactNodeEmpty: ?node: React.ReactNode * ?skipArray: bool -> bool
    /// Converts a React child to an element: non-empty string or number or
    /// `React.Fragment` (React 16.3+) is wrapped in given tag name; empty strings
    /// are discarded.
    abstract ensureElement: child: React.ReactChild option * ?tagName: obj -> React.ReactElement<obj option>
    abstract getDisplayName: ComponentClass: U2<React.ComponentType, INamed> -> string
    abstract isElementOfType: element: obj option * ComponentClass: React.ComponentType<'P> -> bool
    /// Safely invoke the function with the given arguments, if it is indeed a
    /// function, and return its value. Otherwise, return undefined.
    abstract safeInvoke: func: (unit -> 'R) option -> 'R option
    abstract safeInvoke: func: ('A -> 'R) option * arg1: 'A -> 'R option
    abstract safeInvoke: func: ('A -> 'B -> 'R) option * arg1: 'A * arg2: 'B -> 'R option
    abstract safeInvoke: func: ('A -> 'B -> 'C -> 'R) option * arg1: 'A * arg2: 'B * arg3: 'C -> 'R option
    abstract safeInvoke: func: ('A -> 'B -> 'C -> 'D -> 'R) option * arg1: 'A * arg2: 'B * arg3: 'C * arg4: 'D -> 'R option
    /// Safely invoke the provided entity if it is a function; otherwise, return the
    /// entity itself.
    abstract safeInvokeOrValue: funcOrValue: U2<(unit -> 'R), 'R> option -> 'R
    abstract safeInvokeOrValue: funcOrValue: U2<('A -> 'R), 'R> option * arg1: 'A -> 'R
    abstract safeInvokeOrValue: funcOrValue: U2<('A -> 'B -> 'R), 'R> option * arg1: 'A * arg2: 'B -> 'R
    abstract safeInvokeOrValue: funcOrValue: U2<('A -> 'B -> 'C -> 'R), 'R> option * arg1: 'A * arg2: 'B * arg3: 'C -> 'R
    abstract safeInvokeOrValue: funcOrValue: U2<('A -> 'B -> 'C -> 'D -> 'R), 'R> option * arg1: 'A * arg2: 'B * arg3: 'C * arg4: 'D -> 'R
    abstract elementIsOrContains: element: HTMLElement * testElement: HTMLElement -> bool
    /// Returns the difference in length between two arrays. A `null` argument is
    /// considered an empty list. The return value will be positive if `a` is longer
    /// than `b`, negative if the opposite is true, and zero if their lengths are
    /// equal.
    abstract arrayLengthCompare: ?a: ResizeArray<obj option> * ?b: ResizeArray<obj option> -> float
    /// Returns true if the two numbers are within the given tolerance of each other.
    /// This is useful to correct for floating point precision issues, less useful
    /// for integers.
    abstract approxEqual: a: float * b: float * ?tolerance: float -> bool
    /// Clamps the given number between min and max values. Returns value if within
    /// range, or closest bound.
    abstract clamp: ``val``: float * min: float * max: float -> float
    /// Returns the number of decimal places in the given number. 
    abstract countDecimalPlaces: num: float -> float
    /// Throttle an event on an EventTarget by wrapping it in a
    /// `requestAnimationFrame` call. Returns the event handler that was bound to
    /// given eventName so you can clean up after yourself.
    abstract throttleEvent: target: EventTarget * eventName: string * newEventName: string -> (Event -> unit)
    /// Throttle a callback by wrapping it in a `requestAnimationFrame` call. Returns
    /// the throttled function.
    abstract throttleReactEventCallback: callback: (React.SyntheticEvent<obj option> -> ResizeArray<obj option> -> obj option) * ?options: IThrottledReactEventOptions -> (React.SyntheticEvent<obj option> -> unit)
    /// Throttle a method by wrapping it in a `requestAnimationFrame` call. Returns
    /// the throttled function.
    abstract throttle: ``method``: 'T -> 'T

/// Represents anything that has a `name` property such as Functions.
type [<AllowNullLiteral>] INamed =
    abstract name: string option with get, set

type [<AllowNullLiteral>] IThrottledReactEventOptions =
    abstract preventDefault: bool option with get, set
module Classes = __classes
module Keys = __keys
module Utils = __utils

type [<AllowNullLiteral>] IExports =
    /// Show the given menu element at the given offset from the top-left corner of the viewport.
    /// The menu will appear below-right of this point and will flip to below-left if there is not enough
    /// room onscreen. The optional callback will be invoked when this menu closes.
    abstract show: menu: JSX.Element * offset: IOffset * ?onClose: (unit -> unit) * ?isDarkTheme: bool -> unit
    /// Hide the open context menu. 
    abstract hide: unit -> unit
    /// Return whether a context menu is currently open. 
    abstract isOpen: unit -> bool

type [<AllowNullLiteral>] IOffset =
    abstract left: float with get, set
    abstract top: float with get, set
type IconName = @blueprintjs_icons.IconName
type IIntentProps = ______common.IIntentProps
type IProps = ______common.IProps

type [<AllowNullLiteral>] IExports =
    abstract Icon: IconStatic

type [<AllowNullLiteral>] IIconProps =
    inherit IIntentProps
    inherit IProps
    /// This component does not support custom children. Use the `icon` prop. 
    abstract children: obj option with get, set
    /// Color of icon. This is used as the `fill` attribute on the `<svg>` image
    /// so it will override any CSS `color` property, including that set by
    /// `intent`. If this prop is omitted, icon color is inherited from
    /// surrounding text.
    abstract color: string option with get, set
    /// Name of a Blueprint UI icon, or an icon element, to render. This prop is
    /// required because it determines the content of the component, but it can
    /// be explicitly set to falsy values to render nothing.
    /// 
    /// - If `null` or `undefined` or `false`, this component will render
    ///    nothing.
    /// - If given an `IconName` (a string literal union of all icon names), that
    ///    icon will be rendered as an `<svg>` with `<path>` tags. Unknown strings
    ///    will render a blank icon to occupy space.
    /// - If given a `JSX.Element`, that element will be rendered and _all other
    ///    props on this component are ignored._ This type is supported to
    ///    simplify icon support in other Blueprint components. As a consumer, you
    ///    should avoid using `<Icon icon={<Element />}` directly; simply render
    ///    `<Element />` instead.
    abstract icon: U3<IconName, JSX.Element, obj> option with get, set
    /// Size of the icon, in pixels. Blueprint contains 16px and 20px SVG icon
    /// images, and chooses the appropriate resolution based on this prop.
    abstract iconSize: float option with get, set
    /// CSS style properties. 
    abstract style: React.CSSProperties option with get, set
    /// HTML tag to use for the rendered element.
    abstract tagName: obj option with get, set
    /// Description string. This string does not appear in normal browsers, but
    /// it increases accessibility. For instance, screen readers will use it for
    /// aural feedback. By default, this is set to the icon's name. Pass an
    /// explicit falsy value to disable.
    abstract title: U2<string, obj> option with get, set

type [<AllowNullLiteral>] Icon =
    inherit React.PureComponent<obj>
    abstract displayName: string with get, set
    abstract SIZE_STANDARD: float
    abstract SIZE_LARGE: float
    abstract render: unit -> U2<obj, JSX.Element>
    /// Render `<path>` elements for the given icon name. Returns `null` if name is unknown. 
    abstract renderSvgPaths: pathsSize: obj * iconName: obj -> unit

type [<AllowNullLiteral>] IconStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Icon
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Overlay: OverlayStatic

type [<AllowNullLiteral>] IOverlayableProps =
    inherit IOverlayLifecycleProps
    /// Whether the overlay should acquire application focus when it first opens.
    abstract autoFocus: bool option with get, set
    /// Whether pressing the `esc` key should invoke `onClose`.
    abstract canEscapeKeyClose: bool option with get, set
    /// Whether the overlay should prevent focus from leaving itself. That is, if the user attempts
    /// to focus an element outside the overlay and this prop is enabled, then the overlay will
    /// immediately bring focus back to itself. If you are nesting overlay components, either disable
    /// this prop on the "outermost" overlays or mark the nested ones `usePortal={false}`.
    abstract enforceFocus: bool option with get, set
    /// If `true` and `usePortal={true}`, the `Portal` containing the children is created and attached
    /// to the DOM when the overlay is opened for the first time; otherwise this happens when the
    /// component mounts. Lazy mounting provides noticeable performance improvements if you have lots
    /// of overlays at once, such as on each row of a table.
    abstract ``lazy``: bool option with get, set
    /// Indicates how long (in milliseconds) the overlay's enter/leave transition takes.
    /// This is used by React `CSSTransition` to know when a transition completes and must match
    /// the duration of the animation in CSS. Only set this prop if you override Blueprint's default
    /// transitions with new transitions of a different length.
    abstract transitionDuration: float option with get, set
    /// Whether the overlay should be wrapped in a `Portal`, which renders its contents in a new
    /// element attached to `document.body`.
    /// 
    /// This prop essentially determines which element is covered by the backdrop: if `false`,
    /// then only its parent is covered; otherwise, the entire page is covered (because the parent
    /// of the `Portal` is the `<body>` itself).
    /// 
    /// Set this prop to `false` on nested overlays (such as `Dialog` or `Popover`) to ensure that they
    /// are rendered above their parents.
    abstract usePortal: bool option with get, set
    /// A callback that is invoked when user interaction causes the overlay to close, such as
    /// clicking on the overlay or pressing the `esc` key (if enabled).
    /// 
    /// Receives the event from the user's interaction, if there was an event (generally either a
    /// mouse or key event). Note that, since this component is controlled by the `isOpen` prop, it
    /// will not actually close itself until that prop becomes `false`.
    abstract onClose: (React.SyntheticEvent<HTMLElement> -> unit) option with get, set

type [<AllowNullLiteral>] IOverlayLifecycleProps =
    /// Lifecycle method invoked just before the CSS _close_ transition begins on
    /// a child. Receives the DOM element of the child being closed.
    abstract onClosing: (HTMLElement -> unit) option with get, set
    /// Lifecycle method invoked just after the CSS _close_ transition ends but
    /// before the child has been removed from the DOM. Receives the DOM element
    /// of the child being closed.
    abstract onClosed: (HTMLElement -> unit) option with get, set
    /// Lifecycle method invoked just after mounting the child in the DOM but
    /// just before the CSS _open_ transition begins. Receives the DOM element of
    /// the child being opened.
    abstract onOpening: (HTMLElement -> unit) option with get, set
    /// Lifecycle method invoked just after the CSS _open_ transition ends.
    /// Receives the DOM element of the child being opened.
    abstract onOpened: (HTMLElement -> unit) option with get, set

type [<AllowNullLiteral>] IBackdropProps =
    /// CSS class names to apply to backdrop element. 
    abstract backdropClassName: string option with get, set
    /// HTML props for the backdrop element. 
    abstract backdropProps: React.HTMLProps<HTMLDivElement> option with get, set
    /// Whether clicking outside the overlay element (either on backdrop when present or on document)
    /// should invoke `onClose`.
    abstract canOutsideClickClose: bool option with get, set
    /// Whether a container-spanning backdrop element should be rendered behind the contents.
    abstract hasBackdrop: bool option with get, set

type [<AllowNullLiteral>] IOverlayProps =
    inherit IOverlayableProps
    inherit IBackdropProps
    inherit IProps
    /// Toggles the visibility of the overlay and its children.
    /// This prop is required because the component is controlled.
    abstract isOpen: bool with get, set
    /// Name of the transition for internal `CSSTransition`.
    /// Providing your own name here will require defining new CSS transition properties.
    abstract transitionName: string option with get, set

type [<AllowNullLiteral>] IOverlayState =
    abstract hasEverOpened: bool option with get, set

type [<AllowNullLiteral>] Overlay =
    inherit React.PureComponent<IOverlayProps, IOverlayState>
    abstract displayName: string with get, set
    abstract defaultProps: IOverlayProps with get, set
    abstract openStack: obj with get, set
    abstract getLastOpened: obj with get, set
    abstract containerElement: HTMLElement with get, set
    abstract refHandlers: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: nextProps: IOverlayProps -> unit
    abstract componentDidUpdate: prevProps: IOverlayProps -> unit
    abstract componentWillUnmount: unit -> unit
    abstract maybeRenderChild: obj with get, set
    abstract maybeRenderBackdrop: unit -> unit
    abstract overlayWillClose: unit -> unit
    abstract overlayWillOpen: unit -> unit
    abstract handleBackdropMouseDown: obj with get, set
    abstract handleDocumentClick: obj with get, set
    abstract handleDocumentFocus: obj with get, set
    abstract handleKeyDown: obj with get, set

type [<AllowNullLiteral>] OverlayStatic =
    [<Emit "new $0($1...)">] abstract Create: ?props: IOverlayProps * ?context: obj option -> Overlay
type AbstractPureComponent = ______common.AbstractPureComponent
type Intent = ______common.Intent
type IProps = ______common.IProps
type IconName = ___icon_icon.IconName
type IOverlayLifecycleProps = ___overlay_overlay.IOverlayLifecycleProps

type [<AllowNullLiteral>] IExports =
    abstract Alert: AlertStatic

type [<AllowNullLiteral>] IAlertProps =
    inherit IOverlayLifecycleProps
    inherit IProps
    /// Whether pressing <kbd>escape</kbd> when focused on the Alert should cancel the alert.
    /// If this prop is enabled, then either `onCancel` or `onClose` must also be defined.
    abstract canEscapeKeyCancel: bool option with get, set
    /// Whether clicking outside the Alert should cancel the alert.
    /// If this prop is enabled, then either `onCancel` or `onClose` must also be defined.
    abstract canOutsideClickCancel: bool option with get, set
    /// The text for the cancel button.
    /// If this prop is defined, then either `onCancel` or `onClose` must also be defined.
    abstract cancelButtonText: string option with get, set
    /// The text for the confirm (right-most) button.
    /// This button will always appear, and uses the value of the `intent` prop below.
    abstract confirmButtonText: string option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to display on the left side. 
    abstract icon: U2<IconName, JSX.Element> option with get, set
    /// The intent to be applied to the confirm (right-most) button.
    abstract intent: Intent option with get, set
    /// Toggles the visibility of the alert.
    /// This prop is required because the component is controlled.
    abstract isOpen: bool with get, set
    /// CSS styles to apply to the alert.
    abstract style: React.CSSProperties option with get, set
    /// Indicates how long (in milliseconds) the overlay's enter/leave transition takes.
    /// This is used by React `CSSTransition` to know when a transition completes and must match
    /// the duration of the animation in CSS. Only set this prop if you override Blueprint's default
    /// transitions with new transitions of a different length.
    abstract transitionDuration: float option with get, set
    /// Handler invoked when the alert is canceled. Alerts can be **canceled** in the following ways:
    /// - clicking the cancel button (if `cancelButtonText` is defined)
    /// - pressing the escape key (if `canEscapeKeyCancel` is enabled)
    /// - clicking on the overlay backdrop (if `canOutsideClickCancel` is enabled)
    /// 
    /// If any of the `cancel` props are defined, then either `onCancel` or `onClose` must be defined.
    abstract onCancel: ?evt: React.SyntheticEvent<HTMLElement> -> unit
    /// Handler invoked when the confirm button is clicked. Alerts can be **confirmed** in the following ways:
    /// - clicking the confirm button
    /// - focusing on the confirm button and pressing `enter` or `space`
    abstract onConfirm: ?evt: React.SyntheticEvent<HTMLElement> -> unit
    /// Handler invoked when the Alert is confirmed or canceled; see `onConfirm` and `onCancel` for more details.
    /// First argument is `true` if confirmed, `false` otherwise.
    /// This is an alternative to defining separate `onConfirm` and `onCancel` handlers.
    abstract onClose: confirmed: bool * ?evt: React.SyntheticEvent<HTMLElement> -> unit

type [<AllowNullLiteral>] Alert =
    inherit AbstractPureComponent<IAlertProps, obj>
    abstract defaultProps: IAlertProps with get, set
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract validateProps: props: IAlertProps -> unit
    abstract handleCancel: obj with get, set
    abstract handleConfirm: obj with get, set
    abstract internalHandleCallbacks: confirmed: obj * ?evt: obj -> unit

type [<AllowNullLiteral>] AlertStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Alert
type IActionProps = ______common_props.IActionProps
type ILinkProps = ______common_props.ILinkProps
let [<Import("*","@blueprintjs/core/lib/cjs/components/breadcrumbs/breadcrumb")>] Breadcrumb: React.SFC<IBreadcrumbProps> = jsNative

type [<AllowNullLiteral>] IBreadcrumbProps =
    inherit IActionProps
    inherit ILinkProps
type Alignment = ______common_alignment.Alignment
type IActionProps = ______common_props.IActionProps
type IconName = ___icon_icon.IconName

type [<AllowNullLiteral>] IExports =
    abstract AbstractButton: AbstractButtonStatic

type [<AllowNullLiteral>] IButtonProps =
    inherit IActionProps
    /// If set to `true`, the button will display in an active state.
    /// This is equivalent to setting `className={Classes.ACTIVE}`.
    abstract active: bool option with get, set
    /// Text alignment within button. By default, icons and text will be centered
    /// within the button. Passing `"left"` or `"right"` will align the button
    /// text to that side and push `icon` and `rightIcon` to either edge. Passing
    /// `"center"` will center the text and icons together.
    abstract alignText: Alignment option with get, set
    /// A ref handler that receives the native HTML element backing this component. 
    abstract elementRef: (HTMLElement option -> obj option) option with get, set
    /// Whether this button should expand to fill its container. 
    abstract fill: bool option with get, set
    /// Whether this button should use large styles. 
    abstract large: bool option with get, set
    /// If set to `true`, the button will display a centered loading spinner instead of its contents.
    /// The width of the button is not affected by the value of this prop.
    abstract loading: bool option with get, set
    /// Whether this button should use minimal styles. 
    abstract minimal: bool option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render after the text. 
    abstract rightIcon: U2<IconName, JSX.Element> option with get, set
    /// Whether this button should use small styles. 
    abstract small: bool option with get, set
    /// HTML `type` attribute of button. Common values are `"button"` and `"submit"`.
    /// Note that this prop has no effect on `AnchorButton`; it only affects `Button`.
    abstract ``type``: string option with get, set

type [<AllowNullLiteral>] IButtonState =
    abstract isActive: bool with get, set

type [<AllowNullLiteral>] AbstractButton<'H> =
    inherit React.PureComponent<obj, IButtonState>
    abstract state: obj with get, set
    abstract buttonRef: HTMLElement with get, set
    abstract refHandlers: obj with get, set
    abstract currentKeyDown: obj with get, set
    abstract render: unit -> JSX.Element
    abstract getCommonButtonProps: unit -> obj
    abstract handleKeyDown: (React.KeyboardEvent<obj option> -> unit) with get, set
    abstract handleKeyUp: (React.KeyboardEvent<obj option> -> unit) with get, set
    abstract renderChildren: unit -> React.ReactNode

type [<AllowNullLiteral>] AbstractButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AbstractButton<'H>
type AbstractButton = __abstractButton.AbstractButton
type IButtonProps = __abstractButton.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract Button: ButtonStatic
    abstract AnchorButton: AnchorButtonStatic

type [<AllowNullLiteral>] Button =
    inherit AbstractButton<React.ButtonHTMLAttributes<HTMLButtonElement>>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Button

type [<AllowNullLiteral>] AnchorButton =
    inherit AbstractButton<React.AnchorHTMLAttributes<HTMLAnchorElement>>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] AnchorButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AnchorButton
type Alignment = ______common_alignment.Alignment
type HTMLDivProps = ______common_props.HTMLDivProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract ButtonGroup: ButtonGroupStatic

type [<AllowNullLiteral>] IButtonGroupProps =
    inherit IProps
    inherit HTMLDivProps
    /// Text alignment within button. By default, icons and text will be centered
    /// within the button. Passing `"left"` or `"right"` will align the button
    /// text to that side and push `icon` and `rightIcon` to either edge. Passing
    /// `"center"` will center the text and icons together.
    abstract alignText: Alignment option with get, set
    /// Whether the button group should take up the full width of its container.
    abstract fill: bool option with get, set
    /// Whether the child buttons should appear with minimal styling.
    abstract minimal: bool option with get, set
    /// Whether the child buttons should appear with large styling.
    abstract large: bool option with get, set
    /// Whether the button group should appear with vertical styling.
    abstract vertical: bool option with get, set

type [<AllowNullLiteral>] ButtonGroup =
    inherit React.PureComponent<IButtonGroupProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ButtonGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ButtonGroup
type HTMLDivProps = ______common.HTMLDivProps
type IIntentProps = ______common.IIntentProps
type Intent = ______common.Intent
type IProps = ______common.IProps
type IconName = ___icon_icon.IconName

type [<AllowNullLiteral>] IExports =
    abstract Callout: CalloutStatic

/// This component also supports the full range of HTML `<div>` props. 
type [<AllowNullLiteral>] ICalloutProps =
    inherit IIntentProps
    inherit IProps
    inherit HTMLDivProps
    /// Name of a Blueprint UI icon (or an icon element) to render on the left side.
    /// 
    /// If this prop is omitted or `undefined`, the `intent` prop will determine a default icon.
    /// If this prop is explicitly `null`, no icon will be displayed (regardless of `intent`).
    abstract icon: U2<IconName, JSX.Element> option with get, set
    /// Visual intent color to apply to background, title, and icon.
    /// 
    /// Defining this prop also applies a default icon, if the `icon` prop is omitted.
    abstract intent: Intent option with get, set
    /// String content of optional title element.
    /// 
    /// Due to a conflict with the HTML prop types, to provide JSX content simply
    /// pass `<H4>JSX title content</H4>` as first `children` element instead of
    /// using this prop (note uppercase tag name to use the Blueprint Heading
    /// component).
    abstract title: string option with get, set

type [<AllowNullLiteral>] Callout =
    inherit React.PureComponent<ICalloutProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract getIconName: ?icon: obj * ?intent: obj -> unit

type [<AllowNullLiteral>] CalloutStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Callout
type Elevation = ______common_elevation.Elevation
type HTMLDivProps = ______common_props.HTMLDivProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Card: CardStatic

type [<AllowNullLiteral>] ICardProps =
    inherit IProps
    inherit HTMLDivProps
    /// Controls the intensity of the drop shadow beneath the card: the higher
    /// the elevation, the higher the drop shadow. At elevation `0`, no drop
    /// shadow is applied.
    abstract elevation: Elevation option with get, set
    /// Whether the card should respond to user interactions. If set to `true`,
    /// hovering over the card will increase the card's elevation
    /// and change the mouse cursor to a pointer.
    /// 
    /// Recommended when `onClick` is also defined.
    abstract interactive: bool option with get, set
    /// Callback invoked when the card is clicked.
    /// Recommended when `interactive` is `true`.
    abstract onClick: (React.MouseEvent<HTMLDivElement> -> unit) option with get, set

type [<AllowNullLiteral>] Card =
    inherit React.PureComponent<ICardProps, obj>
    abstract displayName: string with get, set
    abstract defaultProps: ICardProps with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CardStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Card
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Collapse: CollapseStatic

type [<AllowNullLiteral>] ICollapseProps =
    inherit IProps
    /// Component to render as the root element.
    /// Useful when rendering a `Collapse` inside a `<table>`, for instance.
    abstract ``component``: React.ReactType option with get, set
    /// Whether the component is open or closed.
    abstract isOpen: bool option with get, set
    /// Whether the child components will remain mounted when the `Collapse` is closed.
    /// Setting to true may improve performance by avoiding re-mounting children.
    abstract keepChildrenMounted: bool option with get, set
    /// The length of time the transition takes, in milliseconds. This must match
    /// the duration of the animation in CSS. Only set this prop if you override
    /// Blueprint's default transitions with new transitions of a different
    /// length.
    abstract transitionDuration: float option with get, set

type [<AllowNullLiteral>] ICollapseState =
    /// The height that should be used for the content animations. This is a CSS value, not just a number. 
    abstract height: string with get, set
    /// The state the element is currently in. 
    abstract animationState: AnimationStates with get, set

type [<RequireQualifiedAccess>] AnimationStates =
    | OPEN_START = 0
    | OPENING = 1
    | OPEN = 2
    | CLOSING_START = 3
    | CLOSING = 4
    | CLOSED = 5

type [<AllowNullLiteral>] Collapse =
    inherit AbstractPureComponent<ICollapseProps, ICollapseState>
    abstract displayName: string with get, set
    abstract defaultProps: ICollapseProps with get, set
    abstract state: obj with get, set
    abstract contents: obj with get, set
    abstract height: obj with get, set
    abstract componentWillReceiveProps: nextProps: ICollapseProps -> unit
    abstract render: unit -> React.ReactElement<obj option>
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract contentsRefHandler: obj with get, set
    abstract onDelayedStateChange: unit -> unit

type [<AllowNullLiteral>] CollapseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Collapse
type Modifiers as PopperModifiers = Popper_js.Modifiers as PopperModifiers
type Position = ______common_position.Position
type IProps = ______common_props.IProps
type IOverlayableProps = ___overlay_overlay.IOverlayableProps

/// Props shared between `Popover` and `Tooltip`. 
type [<AllowNullLiteral>] IPopoverSharedProps =
    inherit IOverlayableProps
    inherit IProps
    /// When enabled, `preventDefault()` is invoked on `click` events that close
    /// this popover, which will prevent those clicks from closing outer
    /// popovers. When disabled, clicking inside a `Classes.POPOVER_DISMISS`
    /// element will close the parent popover.
    /// 
    /// See http://blueprintjs.com/docs/#core/components/popover.closing-on-click
    abstract captureDismiss: bool option with get, set
    /// Initial opened state when uncontrolled.
    abstract defaultIsOpen: bool option with get, set
    /// Prevents the popover from appearing when `true`.
    abstract disabled: bool option with get, set
    /// The amount of time in milliseconds the popover should remain open after
    /// the user hovers off the trigger. The timer is canceled if the user mouses
    /// over the target before it expires.
    abstract hoverCloseDelay: float option with get, set
    /// The amount of time in milliseconds the popover should wait before opening
    /// after the user hovers over the trigger. The timer is canceled if the user
    /// mouses away from the target before it expires.
    abstract hoverOpenDelay: float option with get, set
    /// Whether a popover that uses a `Portal` should automatically inherit the
    /// dark theme from its parent.
    abstract inheritDarkTheme: bool option with get, set
    /// Whether the popover is visible. Passing this prop puts the popover in
    /// controlled mode, where the only way to change visibility is by updating
    /// this property. If `disabled={true}`, this prop will be ignored, and the
    /// popover will remain closed.
    abstract isOpen: bool option with get, set
    /// Popper modifier options, passed directly to internal Popper instance. See
    /// https://popper.js.org/popper-documentation.html#modifiers for complete
    /// details.
    abstract modifiers: PopperModifiers option with get, set
    /// Callback invoked in controlled mode when the popover open state *would*
    /// change due to user interaction.
    abstract onInteraction: (bool -> unit) option with get, set
    /// Whether the popover should open when its target is focused. If `true`,
    /// target will render with `tabindex="0"` to make it focusable via keyboard
    /// navigation.
    abstract openOnTargetFocus: bool option with get, set
    /// A space-delimited string of class names applied to the popover element.
    abstract popoverClassName: string option with get, set
    /// Space-delimited string of class names applied to the `Portal` element if
    /// `usePortal={true}`.
    abstract portalClassName: string option with get, set
    /// The position (relative to the target) at which the popover should appear.
    /// 
    /// The default value of `"auto"` will choose the best position when opened
    /// and will allow the popover to reposition itself to remain onscreen as the
    /// user scrolls around.
    abstract position: U4<Position, string, string, string> option with get, set
    /// Space-delimited string of class names applied to the target element.
    abstract targetClassName: string option with get, set
    /// HTML tag name for the target element. This must be an HTML element to
    /// ensure that it supports the necessary DOM event handlers.
    /// 
    /// By default, a `<span>` tag is used so popovers appear as inline-block
    /// elements and can be nested in text. Use `<div>` tag for a block element.
    abstract targetTagName: obj option with get, set
    /// Whether the popover should be rendered inside a `Portal` attached to
    /// `document.body`.
    /// 
    /// Rendering content inside a `Portal` allows the popover content to escape
    /// the physical bounds of its parent while still being positioned correctly
    /// relative to its target. Using a `Portal` is necessary if any ancestor of
    /// the target hides overflow or uses very complex positioning.
    /// 
    /// Not using a `Portal` can result in smoother performance when scrolling
    /// and allows the popover content to inherit CSS styles from surrounding
    /// elements, but it remains subject to the overflow bounds of its ancestors.
    abstract usePortal: bool option with get, set
    /// HTML tag name for the wrapper element, which also receives the
    /// `className` prop.
    abstract wrapperTagName: obj option with get, set
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IPopoverSharedProps = __popoverSharedProps.IPopoverSharedProps
let [<Import("*","@blueprintjs/core/lib/cjs/components/popover/popover")>] PopoverInteractionKind: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Popover: PopoverStatic

type PopoverInteractionKind =
    obj

type [<AllowNullLiteral>] IPopoverProps =
    inherit IPopoverSharedProps
    /// HTML props for the backdrop element. Can be combined with `backdropClassName`. 
    abstract backdropProps: React.HTMLProps<HTMLDivElement> option with get, set
    /// The content displayed inside the popover. This can instead be provided as
    /// the _second_ element in `children` (first is `target`).
    abstract content: U2<string, JSX.Element> option with get, set
    /// The kind of interaction that triggers the display of the popover.
    abstract interactionKind: PopoverInteractionKind option with get, set
    /// Enables an invisible overlay beneath the popover that captures clicks and
    /// prevents interaction with the rest of the document until the popover is
    /// closed. This prop is only available when `interactionKind` is
    /// `PopoverInteractionKind.CLICK`. When popovers with backdrop are opened,
    /// they become focused.
    abstract hasBackdrop: bool option with get, set
    /// Whether to apply minimal styles to this popover, which includes removing
    /// the arrow and adding `Classes.MINIMAL` to minimize and accelerate the
    /// transitions.
    abstract minimal: bool option with get, set
    /// Ref supplied to the `Classes.POPOVER` element.
    abstract popoverRef: (HTMLDivElement option -> unit) option with get, set
    /// The target to which the popover content is attached. This can instead be
    /// provided as the _first_ element in `children`.
    abstract target: U2<string, JSX.Element> option with get, set

type [<AllowNullLiteral>] IPopoverState =
    abstract transformOrigin: string with get, set
    abstract isOpen: bool with get, set
    abstract hasDarkParent: bool with get, set

type [<AllowNullLiteral>] Popover =
    inherit AbstractPureComponent<IPopoverProps, IPopoverState>
    abstract displayName: string with get, set
    abstract defaultProps: IPopoverProps with get, set
    /// DOM element that contains the popover.
    /// When `usePortal={true}`, this element will be portaled outside the usual DOM flow,
    /// so this reference can be very useful for testing.
    abstract popoverElement: HTMLElement with get, set
    /// DOM element that contains the target. 
    abstract targetElement: HTMLElement with get, set
    abstract state: IPopoverState with get, set
    abstract cancelOpenTimeout: obj with get, set
    abstract isMouseInTargetOrPopover: obj with get, set
    abstract lostFocusOnSamePage: obj with get, set
    abstract popperScheduleUpdate: obj with get, set
    abstract refHandlers: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: nextProps: IPopoverProps -> unit
    abstract componentDidUpdate: unit -> unit
    abstract validateProps: props: obj -> unit
    abstract updateDarkParent: unit -> unit
    abstract renderPopover: obj with get, set
    abstract renderTarget: obj with get, set
    abstract understandChildren: unit -> unit
    abstract getIsOpen: props: obj -> unit
    abstract handleTargetFocus: obj with get, set
    abstract handleTargetBlur: obj with get, set
    abstract handleMouseEnter: obj with get, set
    abstract handleMouseLeave: obj with get, set
    abstract handlePopoverClick: obj with get, set
    abstract handlePopoverResize: obj with get, set
    abstract handleOverlayClose: obj with get, set
    abstract handleTargetClick: obj with get, set
    abstract setOpenState: isOpen: obj * ?e: obj * ?timeout: obj -> unit
    abstract isArrowEnabled: unit -> unit
    abstract isElementInPopover: element: obj -> unit
    abstract isHoverInteractionKind: unit -> unit
    /// Popper modifier that updates React state (for style properties) based on latest data. 
    abstract updatePopoverState: obj with get, set

type [<AllowNullLiteral>] PopoverStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Popover
type IActionProps = ______common_props.IActionProps
type ILinkProps = ______common_props.ILinkProps
type IPopoverProps = ___popover_popover.IPopoverProps

type [<AllowNullLiteral>] IExports =
    abstract MenuItem: MenuItemStatic

type [<AllowNullLiteral>] IMenuItemProps =
    inherit IActionProps
    inherit ILinkProps
    /// Item text, required for usability. 
    abstract text: React.ReactNode with get, set
    /// Whether this menu item should appear with an active state. 
    abstract active: bool option with get, set
    /// Children of this component will be rendered in a __submenu__ that appears when hovering or
    /// clicking on this menu item.
    /// 
    /// Use `text` prop for the content of the menu item itself.
    abstract children: React.ReactNode option with get, set
    /// Whether this menu item is non-interactive. Enabling this prop will ignore `href`, `tabIndex`,
    /// and mouse event handlers (in particular click, down, enter, leave).
    abstract disabled: bool option with get, set
    /// Right-aligned label text content, useful for displaying hotkeys.
    /// 
    /// This prop actually supports JSX elements, but TypeScript will throw an error because
    /// `HTMLAttributes` only allows strings. Use `labelElement` to supply a JSX element in TypeScript.
    abstract label: string option with get, set
    /// Right-aligned label content, useful for displaying hotkeys.
    abstract labelElement: React.ReactNode option with get, set
    /// Whether the text should be allowed to wrap to multiple lines.
    /// If `false`, text will be truncated with an ellipsis when it reaches `max-width`.
    abstract multiline: bool option with get, set
    /// Props to spread to `Popover`. Note that `content` and `minimal` cannot be
    /// changed and `usePortal` defaults to `false` so all submenus will live in
    /// the same container.
    abstract popoverProps: obj option with get, set
    /// Whether an enabled item without a submenu should automatically close its parent popover when clicked.
    abstract shouldDismissPopover: bool option with get, set

type [<AllowNullLiteral>] MenuItem =
    inherit React.PureComponent<obj>
    abstract defaultProps: IMenuItemProps with get, set
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract maybeRenderLabel: ?labelElement: obj -> unit
    abstract maybeRenderPopover: target: obj * ?children: obj -> unit

type [<AllowNullLiteral>] MenuItemStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MenuItem
type Boundary = ______common_boundary.Boundary
type IProps = ______common_props.IProps
type IMenuItemProps = ___menu_menuItem.IMenuItemProps
type IPopoverProps = ___popover_popover.IPopoverProps

type [<AllowNullLiteral>] IExports =
    abstract CollapsibleList: CollapsibleListStatic

type [<AllowNullLiteral>] ICollapsibleListProps =
    inherit IProps
    /// Element to render as dropdown target with `CLICK` interaction to show collapsed menu.
    abstract dropdownTarget: JSX.Element with get, set
    /// Props to pass to the dropdown.
    abstract dropdownProps: IPopoverProps option with get, set
    /// Callback invoked to render each visible item. The item will be wrapped in an `li` with
    /// the optional `visibleItemClassName` prop.
    abstract visibleItemRenderer: (IMenuItemProps -> float -> JSX.Element) with get, set
    /// Which direction the items should collapse from: start or end of the children.
    abstract collapseFrom: Boundary option with get, set
    /// CSS class names to add to `<li>` tags containing each visible item and the dropdown.
    abstract visibleItemClassName: string option with get, set
    /// Exact number of visible items.
    abstract visibleItemCount: float option with get, set

type [<AllowNullLiteral>] CollapsibleList =
    inherit React.Component<ICollapsibleListProps, obj>
    abstract displayName: string with get, set
    abstract defaultProps: ICollapsibleListProps with get, set
    abstract render: unit -> JSX.Element
    abstract partitionChildren: unit -> unit

type [<AllowNullLiteral>] CollapsibleListStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CollapsibleList
type IConstructor = ______common_constructor.IConstructor

type [<AllowNullLiteral>] IExports =
    abstract ContextMenuTarget: WrappedComponent: 'T -> obj

type [<AllowNullLiteral>] IContextMenuTargetComponent =
    inherit React.Component
    abstract render: unit -> React.ReactElement<obj option> option
    abstract renderContextMenu: e: React.MouseEvent<HTMLElement> -> JSX.Element option
    abstract onContextMenuClose: unit -> unit
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IProps = ______common_props.IProps
type IconName = ___icon_icon.IconName
type IBackdropProps = ___overlay_overlay.IBackdropProps
type IOverlayableProps = ___overlay_overlay.IOverlayableProps

type [<AllowNullLiteral>] IExports =
    abstract Dialog: DialogStatic

type [<AllowNullLiteral>] IDialogProps =
    inherit IOverlayableProps
    inherit IBackdropProps
    inherit IProps
    /// Toggles the visibility of the overlay and its children.
    /// This prop is required because the component is controlled.
    abstract isOpen: bool with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render in the
    /// dialog's header. Note that the header will only be rendered if `title` is
    /// provided.
    abstract icon: U2<IconName, JSX.Element> option with get, set
    /// Whether to show the close button in the dialog's header.
    /// Note that the header will only be rendered if `title` is provided.
    abstract isCloseButtonShown: bool option with get, set
    /// CSS styles to apply to the dialog.
    abstract style: React.CSSProperties option with get, set
    /// Title of the dialog. If provided, an element with `Classes.DIALOG_HEADER`
    /// will be rendered inside the dialog before any children elements.
    abstract title: React.ReactNode option with get, set
    /// Name of the transition for internal `CSSTransition`. Providing your own
    /// name here will require defining new CSS transition properties.
    abstract transitionName: string option with get, set

type [<AllowNullLiteral>] Dialog =
    inherit AbstractPureComponent<IDialogProps, obj>
    abstract defaultProps: IDialogProps with get, set
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract validateProps: props: IDialogProps -> unit
    abstract maybeRenderCloseButton: unit -> unit
    abstract maybeRenderHeader: unit -> unit

type [<AllowNullLiteral>] DialogStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Dialog
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Divider: DividerStatic

type [<AllowNullLiteral>] IDividerProps =
    inherit IProps
    inherit React.HTMLAttributes<HTMLElement>
    /// HTML tag to use for element.
    abstract tagName: obj option with get, set

type [<AllowNullLiteral>] Divider =
    inherit React.PureComponent<IDividerProps>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DividerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Divider
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IIntentProps = ______common_props.IIntentProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract EditableText: EditableTextStatic

type [<AllowNullLiteral>] IEditableTextProps =
    inherit IIntentProps
    inherit IProps
    /// If `true` and in multiline mode, the `enter` key will trigger onConfirm and `mod+enter`
    /// will insert a newline. If `false`, the key bindings are inverted such that `enter`
    /// adds a newline.
    abstract confirmOnEnterKey: bool option with get, set
    /// Default text value of uncontrolled input. 
    abstract defaultValue: string option with get, set
    /// Whether the text can be edited.
    abstract disabled: bool option with get, set
    /// Whether the component is currently being edited. 
    abstract isEditing: bool option with get, set
    /// Maximum number of characters allowed. Unlimited by default. 
    abstract maxLength: float option with get, set
    /// Minimum width in pixels of the input, when not `multiline`. 
    abstract minWidth: float option with get, set
    /// Whether the component supports multiple lines of text.
    /// This prop should not be changed during the component's lifetime.
    abstract multiline: bool option with get, set
    /// Maximum number of lines before scrolling begins, when `multiline`.
    abstract maxLines: float option with get, set
    /// Minimum number of lines (essentially minimum height), when `multiline`.
    abstract minLines: float option with get, set
    /// Placeholder text when there is no value.
    abstract placeholder: string option with get, set
    /// Whether the entire text field should be selected on focus.
    /// If `false`, the cursor is placed at the end of the text.
    abstract selectAllOnFocus: bool option with get, set
    /// Text value of controlled input. 
    abstract value: string option with get, set
    /// Callback invoked when user cancels input with the `esc` key. Receives last confirmed value. 
    abstract onCancel: value: string -> unit
    /// Callback invoked when user changes input in any way. 
    abstract onChange: value: string -> unit
    /// Callback invoked when user confirms value with `enter` key or by blurring input. 
    abstract onConfirm: value: string -> unit
    /// Callback invoked after the user enters edit mode. 
    abstract onEdit: value: string -> unit

type [<AllowNullLiteral>] IEditableTextState =
    /// Pixel height of the input, measured from span size 
    abstract inputHeight: float option with get, set
    /// Pixel width of the input, measured from span size 
    abstract inputWidth: float option with get, set
    /// Whether the value is currently being edited 
    abstract isEditing: bool option with get, set
    /// The last confirmed value 
    abstract lastValue: string option with get, set
    /// The controlled input value, may be different from prop during editing 
    abstract value: string option with get, set

type [<AllowNullLiteral>] EditableText =
    inherit AbstractPureComponent<IEditableTextProps, IEditableTextState>
    abstract displayName: string with get, set
    abstract defaultProps: IEditableTextProps with get, set
    abstract valueElement: obj with get, set
    abstract refHandlers: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: ``_``: IEditableTextProps * prevState: IEditableTextState -> unit
    abstract componentWillReceiveProps: nextProps: IEditableTextProps -> unit
    abstract cancelEditing: (unit -> unit) with get, set
    abstract toggleEditing: (unit -> unit) with get, set
    abstract handleFocus: obj with get, set
    abstract handleTextChange: obj with get, set
    abstract handleKeyEvent: obj with get, set
    abstract maybeRenderInput: value: obj -> unit
    abstract updateInputDimensions: unit -> unit

type [<AllowNullLiteral>] EditableTextStatic =
    [<Emit "new $0($1...)">] abstract Create: ?props: IEditableTextProps * ?context: obj option -> EditableText
type HTMLDivProps = ______common_props.HTMLDivProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract ControlGroup: ControlGroupStatic

type [<AllowNullLiteral>] IControlGroupProps =
    inherit IProps
    inherit HTMLDivProps
    /// Whether the control group should take up the full width of its container.
    abstract fill: bool option with get, set
    /// Whether the control group should appear with vertical styling.
    abstract vertical: bool option with get, set

type [<AllowNullLiteral>] ControlGroup =
    inherit React.PureComponent<IControlGroupProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ControlGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ControlGroup
type Alignment = ______common_alignment.Alignment
type HTMLInputProps = ______common_props.HTMLInputProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Switch: SwitchStatic
    abstract Radio: RadioStatic
    abstract Checkbox: CheckboxStatic

type [<AllowNullLiteral>] IControlProps =
    inherit IProps
    inherit HTMLInputProps
    /// Alignment of the indicator within container.
    abstract alignIndicator: Alignment option with get, set
    /// Whether the control is checked. 
    abstract ``checked``: bool option with get, set
    /// JSX label for the control. 
    abstract children: React.ReactNode option with get, set
    /// Whether the control is initially checked (uncontrolled mode). 
    abstract defaultChecked: bool option with get, set
    /// Whether the control is non-interactive. 
    abstract disabled: bool option with get, set
    /// Ref handler that receives HTML `<input>` element backing this component. 
    abstract inputRef: (HTMLInputElement option -> obj option) option with get, set
    /// Whether the control should appear as an inline element. 
    abstract ``inline``: bool option with get, set
    /// Text label for the control.
    /// 
    /// Use `children` or `labelElement` to supply JSX content. This prop actually supports JSX elements,
    /// but TypeScript will throw an error because `HTMLAttributes` only allows strings.
    abstract label: string option with get, set
    /// JSX Element label for the control.
    /// 
    /// This prop is a workaround for TypeScript consumers as the type definition for `label` only
    /// accepts strings. JavaScript consumers can provide a JSX element directly to `label`.
    abstract labelElement: React.ReactNode option with get, set
    /// Whether this control should use large styles. 
    abstract large: bool option with get, set
    /// Event handler invoked when input value is changed. 
    abstract onChange: React.FormEventHandler<HTMLInputElement> option with get, set
    /// Name of the HTML tag that wraps the checkbox.
    /// 
    /// By default a `<label>` is used, which effectively enlarges the click
    /// target to include all of its children. Supply a different tag name if
    /// this behavior is undesirable or you're listening to click events from a
    /// parent element (as the label can register duplicate clicks).
    abstract tagName: obj option with get, set

type [<AllowNullLiteral>] ISwitchProps =
    inherit IControlProps

type [<AllowNullLiteral>] Switch =
    inherit React.PureComponent<ISwitchProps>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] SwitchStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Switch

type [<AllowNullLiteral>] IRadioProps =
    inherit IControlProps

type [<AllowNullLiteral>] Radio =
    inherit React.PureComponent<IRadioProps>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] RadioStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Radio

type [<AllowNullLiteral>] ICheckboxProps =
    inherit IControlProps
    /// Whether this checkbox is initially indeterminate (uncontrolled mode). 
    abstract defaultIndeterminate: bool option with get, set
    /// Whether this checkbox is indeterminate, or "partially checked."
    /// The checkbox will appear with a small dash instead of a tick to indicate that the value
    /// is not exactly true or false.
    /// 
    /// Note that this prop takes precendence over `checked`: if a checkbox is marked both
    /// `checked` and `indeterminate` via props, it will appear as indeterminate in the DOM.
    abstract indeterminate: bool option with get, set

type [<AllowNullLiteral>] ICheckboxState =
    abstract indeterminate: bool with get, set

type [<AllowNullLiteral>] Checkbox =
    inherit React.PureComponent<ICheckboxProps, ICheckboxState>
    abstract displayName: string with get, set
    abstract state: ICheckboxState with get, set
    abstract input: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentWillReceiveProps: {indeterminate}: ICheckboxProps -> unit
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract updateIndeterminate: unit -> unit
    abstract handleChange: obj with get, set
    abstract handleInputRef: obj with get, set

type [<AllowNullLiteral>] CheckboxStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Checkbox
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract FileInput: FileInputStatic

type [<AllowNullLiteral>] IFileInputProps =
    inherit React.LabelHTMLAttributes<HTMLLabelElement>
    inherit IProps
    /// Whether the file input is non-interactive.
    /// Setting this to `true` will automatically disable the child input too.
    abstract disabled: bool option with get, set
    /// Whether the file input should take up the full width of its container.
    abstract fill: bool option with get, set
    /// The props to pass to the child input.
    /// `disabled` will be ignored in favor of the top-level prop.
    /// `type` will be ignored, because the input _must_ be `type="file"`.
    /// Pass `onChange` here to be notified when the user selects a file.
    abstract inputProps: React.HTMLProps<HTMLInputElement> option with get, set
    /// Whether the file input should appear with large styling.
    abstract large: bool option with get, set
    /// Callback invoked on `<input>` `change` events.
    /// 
    /// This callback is offered as a convenience; it is equivalent to passing
    /// `onChange` to `inputProps`.
    /// 
    /// __Note:__ The top-level `onChange` prop is passed to the wrapping
    /// `<label>` rather than the `<input>`, which may not be what you expect.
    abstract onInputChange: React.FormEventHandler<HTMLInputElement> option with get, set
    /// The text to display.
    abstract text: React.ReactNode option with get, set

type [<AllowNullLiteral>] FileInput =
    inherit React.PureComponent<IFileInputProps, obj>
    abstract displayName: string with get, set
    abstract defaultProps: IFileInputProps with get, set
    abstract render: unit -> JSX.Element
    abstract handleInputChange: obj with get, set

type [<AllowNullLiteral>] FileInputStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> FileInput
type IIntentProps = ______common_props.IIntentProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract FormGroup: FormGroupStatic

type [<AllowNullLiteral>] IFormGroupProps =
    inherit IIntentProps
    inherit IProps
    /// Whether form group should appear as non-interactive.
    /// Remember that `input` elements must be disabled separately.
    abstract disabled: bool option with get, set
    /// Optional helper text. The given content will be wrapped in
    /// `Classes.FORM_HELPER_TEXT` and displayed beneath `children`.
    /// Helper text color is determined by the `intent`.
    abstract helperText: React.ReactNode option with get, set
    /// Whether to render the label and children on a single line. 
    abstract ``inline``: bool option with get, set
    /// Label of this form group. 
    abstract label: React.ReactNode option with get, set
    /// `id` attribute of the labelable form element that this `FormGroup` controls,
    /// used as `<label for>` attribute.
    abstract labelFor: string option with get, set
    /// Optional secondary text that appears after the label.
    abstract labelInfo: React.ReactNode option with get, set

type [<AllowNullLiteral>] FormGroup =
    inherit React.PureComponent<IFormGroupProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract getClassName: unit -> unit

type [<AllowNullLiteral>] FormGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> FormGroup
type HTMLInputProps = ______common_props.HTMLInputProps
type IControlledProps = ______common_props.IControlledProps
type IIntentProps = ______common_props.IIntentProps
type IProps = ______common_props.IProps
type IconName = ___icon_icon.IconName

type [<AllowNullLiteral>] IExports =
    abstract InputGroup: InputGroupStatic

type [<AllowNullLiteral>] IInputGroupProps =
    inherit IControlledProps
    inherit IIntentProps
    inherit IProps
    /// Whether the input is non-interactive.
    /// Note that `rightElement` must be disabled separately; this prop will not affect it.
    abstract disabled: bool option with get, set
    /// Ref handler that receives HTML `<input>` element backing this component. 
    abstract inputRef: (HTMLInputElement option -> obj option) option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render on the left side of the input group,
    /// before the user's cursor.
    abstract leftIcon: U2<IconName, JSX.Element> option with get, set
    /// Whether this input should use large styles. 
    abstract large: bool option with get, set
    /// Placeholder text in the absence of any value. 
    abstract placeholder: string option with get, set
    /// Element to render on right side of input.
    /// For best results, use a minimal button, tag, or small spinner.
    abstract rightElement: JSX.Element option with get, set
    /// Whether the input (and any buttons) should appear with rounded caps. 
    abstract round: bool option with get, set
    /// HTML `input` type attribute.
    abstract ``type``: string option with get, set

type [<AllowNullLiteral>] IInputGroupState =
    abstract rightElementWidth: float with get, set

type [<AllowNullLiteral>] InputGroup =
    inherit React.PureComponent<obj, IInputGroupState>
    abstract displayName: string with get, set
    abstract state: IInputGroupState with get, set
    abstract rightElement: obj with get, set
    abstract refHandlers: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract maybeRenderRightElement: unit -> unit
    abstract updateInputWidth: unit -> unit

type [<AllowNullLiteral>] InputGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> InputGroup
type IconName = @blueprintjs_icons.IconName
type AbstractPureComponent = ______common.AbstractPureComponent
type HTMLInputProps = ______common.HTMLInputProps
type IIntentProps = ______common.IIntentProps
type IProps = ______common.IProps
type Position = ______common.Position

type [<AllowNullLiteral>] IExports =
    abstract NumericInput: NumericInputStatic

type [<AllowNullLiteral>] INumericInputProps =
    inherit IIntentProps
    inherit IProps
    /// Whether to allow only floating-point number characters in the field,
    /// mimicking the native `input[type="number"]`.
    abstract allowNumericCharactersOnly: bool option with get, set
    /// The position of the buttons with respect to the input field.
    abstract buttonPosition: U2<obj, string> option with get, set
    /// Whether the value should be clamped to `[min, max]` on blur.
    /// The value will be clamped to each bound only if the bound is defined.
    /// Note that native `input[type="number"]` controls do *NOT* clamp on blur.
    abstract clampValueOnBlur: bool option with get, set
    /// Whether the input is non-interactive.
    abstract disabled: bool option with get, set
    /// Whether the numeric input should take up the full width of its container. 
    abstract fill: bool option with get, set
    /// Ref handler that receives HTML `<input>` element backing this component.
    abstract inputRef: (HTMLInputElement option -> obj option) option with get, set
    /// If set to `true`, the input will display with larger styling.
    /// This is equivalent to setting `Classes.LARGE` via className on the
    /// parent control group and on the child input group.
    abstract large: bool option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render on the left side of input.
    abstract leftIcon: U2<IconName, JSX.Element> option with get, set
    /// The placeholder text in the absence of any value. 
    abstract placeholder: string option with get, set
    /// The increment between successive values when <kbd>shift</kbd> is held.
    /// Pass explicit `null` value to disable this interaction.
    abstract majorStepSize: float option with get, set
    /// The maximum value of the input. 
    abstract max: float option with get, set
    /// The minimum value of the input. 
    abstract min: float option with get, set
    /// The increment between successive values when <kbd>alt</kbd> is held.
    /// Pass explicit `null` value to disable this interaction.
    abstract minorStepSize: float option with get, set
    /// Whether the entire text field should be selected on focus.
    abstract selectAllOnFocus: bool option with get, set
    /// Whether the entire text field should be selected on increment.
    abstract selectAllOnIncrement: bool option with get, set
    /// The increment between successive values when no modifier keys are held.
    abstract stepSize: float option with get, set
    /// The value to display in the input field. 
    abstract value: U2<float, string> option with get, set
    /// The callback invoked when the value changes due to a button click. 
    abstract onButtonClick: valueAsNumber: float * valueAsString: string -> unit
    /// The callback invoked when the value changes due to typing, arrow keys, or button clicks. 
    abstract onValueChange: valueAsNumber: float * valueAsString: string -> unit

type [<AllowNullLiteral>] INumericInputState =
    abstract isInputGroupFocused: bool option with get, set
    abstract isButtonGroupFocused: bool option with get, set
    abstract shouldSelectAfterUpdate: bool option with get, set
    abstract stepMaxPrecision: float option with get, set
    abstract value: string option with get, set

type [<AllowNullLiteral>] NumericInput =
    inherit AbstractPureComponent<obj, INumericInputState>
    abstract displayName: string with get, set
    abstract VALUE_EMPTY: string with get, set
    abstract VALUE_ZERO: string with get, set
    abstract defaultProps: INumericInputProps with get, set
    abstract DECREMENT_KEY: obj with get, set
    abstract INCREMENT_KEY: obj with get, set
    abstract DECREMENT_ICON_NAME: obj with get, set
    abstract INCREMENT_ICON_NAME: obj with get, set
    /// A regex that matches a string of length 1 (i.e. a standalone character)
    /// if and only if it is a floating-point number character as defined by W3C:
    /// https://www.w3.org/TR/2012/WD-html-markup-20120329/datatypes.html#common.data.float
    /// 
    /// Floating-point number characters are the only characters that can be
    /// printed within a default input[type="number"]. This component should
    /// behave the same way when this.props.allowNumericCharactersOnly = true.
    /// See here for the input[type="number"].value spec:
    /// https://www.w3.org/TR/2012/WD-html-markup-20120329/input.number.html#input.number.attrs.value
    abstract FLOATING_POINT_NUMBER_CHARACTER_REGEX: obj with get, set
    abstract CONTINUOUS_CHANGE_DELAY: obj with get, set
    abstract CONTINUOUS_CHANGE_INTERVAL: obj with get, set
    abstract inputElement: obj with get, set
    abstract didPasteEventJustOccur: obj with get, set
    abstract shouldSelectAfterUpdate: obj with get, set
    abstract delta: obj with get, set
    abstract intervalId: obj with get, set
    abstract componentWillReceiveProps: nextProps: obj -> unit
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: unit -> unit
    abstract validateProps: nextProps: obj -> unit
    abstract renderButton: key: obj * iconName: obj * onMouseDown: obj * onKeyDown: obj * onKeyUp: obj -> unit
    abstract inputRef: obj with get, set
    abstract handleDecrementButtonClick: obj with get, set
    abstract handleDecrementButtonMouseDown: obj with get, set
    abstract handleDecrementButtonKeyDown: obj with get, set
    abstract handleDecrementButtonKeyUp: obj with get, set
    abstract handleIncrementButtonClick: obj with get, set
    abstract handleIncrementButtonMouseDown: obj with get, set
    abstract handleIncrementButtonKeyDown: obj with get, set
    abstract handleIncrementButtonKeyUp: obj with get, set
    abstract handleButtonClick: obj with get, set
    abstract handleButtonFocus: obj with get, set
    abstract handleButtonBlur: obj with get, set
    abstract handleButtonKeyUp: obj with get, set
    abstract startContinuousChange: unit -> unit
    abstract stopContinuousChange: obj with get, set
    abstract handleContinuousChange: obj with get, set
    abstract handleInputFocus: obj with get, set
    abstract handleInputBlur: obj with get, set
    abstract handleInputKeyDown: obj with get, set
    abstract handleInputKeyPress: obj with get, set
    abstract handleInputPaste: obj with get, set
    abstract handleInputChange: obj with get, set
    abstract invokeValueCallback: value: obj * callback: obj -> unit
    abstract incrementValue: delta: obj -> unit
    abstract getIncrementDelta: direction: obj * isShiftKeyPressed: obj * isAltKeyPressed: obj -> unit
    abstract getSanitizedValue: value: obj * ?delta: obj * ?min: obj * ?max: obj -> unit
    abstract getValueOrEmptyValue: value: obj -> unit
    abstract isValueNumeric: value: obj -> unit
    abstract isKeyboardEventDisabledForBasicNumericEntry: e: obj -> unit
    abstract isFloatingPointNumericCharacter: character: obj -> unit
    abstract getStepMaxPrecision: props: obj -> unit
    abstract toMaxPrecision: value: obj -> unit
    abstract updateDelta: direction: obj * e: obj -> unit

type [<AllowNullLiteral>] NumericInputStatic =
    [<Emit "new $0($1...)">] abstract Create: ?props: obj * ?context: obj option -> NumericInput
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IOptionProps = ______common_props.IOptionProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract RadioGroup: RadioGroupStatic

type [<AllowNullLiteral>] IRadioGroupProps =
    inherit IProps
    /// Whether the group and _all_ its radios are disabled.
    /// Individual radios can be disabled using their `disabled` prop.
    abstract disabled: bool option with get, set
    /// Whether the radio buttons are to be displayed inline horizontally.
    abstract ``inline``: bool option with get, set
    /// Optional label text to display above the radio buttons. 
    abstract label: string option with get, set
    /// Name of the group, used to link radio buttons together in HTML.
    /// If omitted, a unique name will be generated internally.
    abstract name: string option with get, set
    /// Callback invoked when the currently selected radio changes.
    /// Use `event.currentTarget.value` to read the currently selected value.
    /// This prop is required because this component only supports controlled usage.
    abstract onChange: (React.FormEvent<HTMLInputElement> -> unit) with get, set
    /// Array of options to render in the group. This prop is mutually exclusive
    /// with `children`: either provide an array of `IOptionProps` objects or
    /// provide `<Radio>` children elements.
    abstract options: ResizeArray<IOptionProps> option with get, set
    /// Value of the selected radio. The child with this value will be `:checked`. 
    abstract selectedValue: U2<string, float> option with get, set

type [<AllowNullLiteral>] RadioGroup =
    inherit AbstractPureComponent<IRadioGroupProps, obj>
    abstract displayName: string with get, set
    abstract autoGroupName: obj with get, set
    abstract render: unit -> JSX.Element
    abstract validateProps: unit -> unit
    abstract renderChildren: unit -> unit
    abstract renderOptions: unit -> unit
    abstract getRadioProps: optionProps: obj -> unit

type [<AllowNullLiteral>] RadioGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> RadioGroup
type IIntentProps = ______common_props.IIntentProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract TextArea: TextAreaStatic

type [<AllowNullLiteral>] ITextAreaProps =
    inherit IIntentProps
    inherit IProps
    inherit React.TextareaHTMLAttributes<HTMLTextAreaElement>
    /// Whether the text area should take up the full width of its container.
    abstract fill: bool option with get, set
    /// Whether the text area should appear with large styling.
    abstract large: bool option with get, set
    /// Ref handler that receives HTML `<textarea>` element backing this component.
    abstract inputRef: (HTMLTextAreaElement option -> obj option) option with get, set

type [<AllowNullLiteral>] TextArea =
    inherit React.PureComponent<ITextAreaProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] TextAreaStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> TextArea
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H1: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H2: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H3: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H4: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H5: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] H6: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] Blockquote: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] Code: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] Pre: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] Label: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] OL: React.StatelessComponent<obj> = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/html/html")>] UL: React.StatelessComponent<obj> = jsNative

type [<AllowNullLiteral>] IElementRefProps<'E> =
    /// Ref handler to access the instance of the internal HTML element. 
    abstract elementRef: ('E option -> unit) option with get, set
type IOptionProps = ______common_props.IOptionProps
type IElementRefProps = ___html_html.IElementRefProps
type IIconProps = ___icon_icon.IIconProps

type [<AllowNullLiteral>] IExports =
    abstract HTMLSelect: HTMLSelectStatic

type [<AllowNullLiteral>] IHTMLSelectProps =
    inherit IElementRefProps<HTMLSelectElement>
    inherit React.SelectHTMLAttributes<HTMLSelectElement>
    /// Whether this element is non-interactive. 
    abstract disabled: bool option with get, set
    /// Whether this element should fill its container. 
    abstract fill: bool option with get, set
    /// Props to spread to the `<Icon>` element. 
    abstract iconProps: obj option with get, set
    /// Whether to use large styles. 
    abstract large: bool option with get, set
    /// Whether to use minimal styles. 
    abstract minimal: bool option with get, set
    /// Multiple select is not supported. 
    abstract multiple: obj option with get, set
    /// Change event handler. Use `event.currentTarget.value` to access the new value. 
    abstract onChange: React.ChangeEventHandler<HTMLSelectElement> option with get, set
    /// Shorthand for supplying options: an array of basic types or
    /// `{ label?, value }` objects. If no `label` is supplied, `value`
    /// will be used as the label.
    abstract options: Array<U3<string, float, IOptionProps>> option with get, set
    /// Controlled value of this component. 
    abstract value: U2<string, float> option with get, set

type [<AllowNullLiteral>] HTMLSelect =
    inherit React.PureComponent<IHTMLSelectProps>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] HTMLSelectStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> HTMLSelect
type IElementRefProps = ___html_html.IElementRefProps

type [<AllowNullLiteral>] IExports =
    abstract HTMLTable: HTMLTableStatic

type [<AllowNullLiteral>] IHTMLTableProps =
    inherit React.HTMLAttributes<HTMLTableElement>
    inherit IElementRefProps<HTMLTableElement>
    /// Enables borders between rows and cells. 
    abstract bordered: bool option with get, set
    /// Use small, condensed appearance. 
    abstract condensed: bool option with get, set
    /// Enables hover styles on row. 
    abstract interactive: bool option with get, set
    /// Use small, condensed appearance for this element and all child elements.
    abstract small: bool option with get, set
    /// Use an alternate background color on odd rows. 
    abstract striped: bool option with get, set

type [<AllowNullLiteral>] HTMLTable =
    inherit React.PureComponent<IHTMLTableProps>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] HTMLTableStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> HTMLTable
type AbstractPureComponent = ______common.AbstractPureComponent
type IProps = ______common.IProps

type [<AllowNullLiteral>] IExports =
    abstract Hotkey: HotkeyStatic

type [<AllowNullLiteral>] IHotkeyProps =
    inherit IProps
    /// Whether the hotkey should be triggerable when focused in a text input.
    abstract allowInInput: bool option with get, set
    /// Hotkey combination string, such as "space" or "cmd+n".
    abstract combo: string with get, set
    /// Whether the hotkey cannot be triggered.
    abstract disabled: bool option with get, set
    /// Human-friendly label for the hotkey.
    abstract label: string with get, set
    /// If `false`, the hotkey is active only when the target is focused. If
    /// `true`, the hotkey can be triggered regardless of what component is
    /// focused.
    abstract ``global``: bool option with get, set
    /// Unless the hotkey is global, you must specify a group where the hotkey
    /// will be displayed in the hotkeys dialog. This string will be displayed
    /// in a header at the start of the group of hotkeys.
    abstract group: string option with get, set
    /// When `true`, invokes `event.preventDefault()` before the respective `onKeyDown` and
    /// `onKeyUp` callbacks are invoked. Enabling this can simplify handler implementations.
    abstract preventDefault: bool option with get, set
    /// When `true`, invokes `event.stopPropagation()` before the respective `onKeyDown` and
    /// `onKeyUp` callbacks are invoked. Enabling this can simplify handler implementations.
    abstract stopPropagation: bool option with get, set
    /// `keydown` event handler.
    abstract onKeyDown: e: KeyboardEvent -> obj option
    /// `keyup` event handler.
    abstract onKeyUp: e: KeyboardEvent -> obj option

type [<AllowNullLiteral>] Hotkey =
    inherit AbstractPureComponent<IHotkeyProps, obj>
    abstract displayName: string with get, set
    abstract defaultProps: obj with get, set
    abstract render: unit -> JSX.Element
    abstract validateProps: props: IHotkeyProps -> unit

type [<AllowNullLiteral>] HotkeyStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Hotkey
type IProps = ______common.IProps

type [<AllowNullLiteral>] IExports =
    abstract KeyCombo: KeyComboStatic

type [<AllowNullLiteral>] IKeyComboProps =
    inherit IProps
    /// The key combo to display, such as `"cmd + s"`. 
    abstract combo: string with get, set
    /// Whether to render in a minimal style.
    /// If `false`, each key in the combo will be rendered inside a `<kbd>` tag.
    /// If `true`, only the icon or short name of a key will be rendered with no wrapper styles.
    abstract minimal: bool option with get, set

type [<AllowNullLiteral>] KeyCombo =
    inherit React.Component<IKeyComboProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract renderKey: obj with get, set
    abstract renderMinimalKey: obj with get, set

type [<AllowNullLiteral>] KeyComboStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> KeyCombo
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] KeyCodes: IKeyCodeTable = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] Modifiers: IKeyCodeTable = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] ModifierBitMasks: IKeyCodeReverseTable = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] Aliases: IKeyMap = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] ShiftKeys: IKeyMap = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] parseKeyCombo: (string -> IKeyCombo) = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] getKeyComboString: (KeyboardEvent -> string) = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] getKeyCombo: (KeyboardEvent -> IKeyCombo) = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/hotkeys/hotkeyParser")>] normalizeKeyCombo: (string -> string -> ResizeArray<string>) = jsNative

type [<AllowNullLiteral>] IExports =
    abstract comboMatches: a: IKeyCombo * b: IKeyCombo -> bool

type [<AllowNullLiteral>] IKeyCodeTable =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: code: float -> string with get, set

type [<AllowNullLiteral>] IKeyCodeReverseTable =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> float with get, set

type [<AllowNullLiteral>] IKeyMap =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] IKeyCombo =
    abstract key: string option with get, set
    abstract modifiers: float with get, set
type ReactNode = React.ReactNode
type IHotkeyProps = __hotkey.IHotkeyProps
type IKeyCombo = __hotkeyParser.IKeyCombo
type IHotkeysProps = __hotkeys.IHotkeysProps

type [<AllowNullLiteral>] IExports =
    abstract HotkeysEvents: HotkeysEventsStatic

type [<StringEnum>] [<RequireQualifiedAccess>] HotkeyScope =
    | [<CompiledName "local">] LOCAL
    | [<CompiledName "global">] GLOBAL

type [<AllowNullLiteral>] IHotkeyAction =
    abstract combo: IKeyCombo with get, set
    abstract props: IHotkeyProps with get, set

type [<AllowNullLiteral>] HotkeysEvents =
    abstract scope: obj with get, set
    abstract actions: obj with get, set
    abstract count: unit -> float
    abstract clear: unit -> unit
    abstract setHotkeys: props: obj -> unit
    abstract handleKeyDown: (KeyboardEvent -> unit) with get, set
    abstract handleKeyUp: (KeyboardEvent -> unit) with get, set
    abstract invokeNamedCallbackIfComboRecognized: combo: obj * callbackName: obj * e: obj -> unit
    abstract isScope: props: obj -> unit
    abstract isTextInput: e: obj -> unit

type [<AllowNullLiteral>] HotkeysEventsStatic =
    [<Emit "new $0($1...)">] abstract Create: scope: HotkeyScope -> HotkeysEvents
type IConstructor = ______common_constructor.IConstructor
type IHotkeysProps = __hotkeys.IHotkeysProps
type HotkeysEvents = __hotkeysEvents.HotkeysEvents

type [<AllowNullLiteral>] IExports =
    abstract HotkeysTarget: WrappedComponent: 'T -> obj

type [<AllowNullLiteral>] IHotkeysTargetComponent =
    inherit React.Component
    /// Components decorated with the `@HotkeysTarget` decorator must implement React's component `render` function. 
    abstract render: unit -> React.ReactElement<obj option> option
    /// Components decorated with the `@HotkeysTarget` decorator must implement
    /// this method, and it must return a `Hotkeys` React element.
    abstract renderHotkeys: unit -> React.ReactElement<IHotkeysProps>
type IDialogProps = ______components.IDialogProps
type IHotkeyProps = __hotkey.IHotkeyProps

type [<AllowNullLiteral>] IExports =
    abstract isHotkeysDialogShowing: unit -> bool
    abstract setHotkeysDialogProps: props: obj -> unit
    abstract showHotkeysDialog: hotkeys: ResizeArray<IHotkeyProps> -> unit
    abstract hideHotkeysDialog: unit -> unit
    /// Use this function instead of `hideHotkeysDialog` if you need to ensure that all hotkey listeners
    /// have time to execute with the dialog in a consistent open state. This can avoid flickering the
    /// dialog between open and closed states as successive listeners fire.
    abstract hideHotkeysDialogAfterDelay: unit -> unit

type [<AllowNullLiteral>] IHotkeysDialogProps =
    inherit IDialogProps
    /// This string displayed as the group name in the hotkeys dialog for all
    /// global hotkeys.
    abstract globalHotkeysGroup: string option with get, set
type AbstractPureComponent = ______common.AbstractPureComponent
type IProps = ______common.IProps

type [<AllowNullLiteral>] IExports =
    abstract Hotkeys: HotkeysStatic

type [<AllowNullLiteral>] IHotkeysProps =
    inherit IProps
    /// In order to make local hotkeys work on elements that are not normally
    /// focusable, such as `<div>`s or `<span>`s, we add a `tabIndex` attribute
    /// to the hotkey target, which makes it focusable. By default, we use `0`,
    /// but you can override this value to change the tab navigation behavior
    /// of the component. You may even set this value to `null`, which will omit
    /// the `tabIndex` from the component decorated by `HotkeysTarget`.
    abstract tabIndex: float option with get, set

type [<AllowNullLiteral>] Hotkeys =
    inherit AbstractPureComponent<IHotkeysProps, obj>
    abstract displayName: string with get, set
    abstract defaultProps: obj with get, set
    abstract render: unit -> JSX.Element
    abstract validateProps: props: obj -> unit

type [<AllowNullLiteral>] HotkeysStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Hotkeys
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract MenuDivider: MenuDividerStatic

type [<AllowNullLiteral>] IMenuDividerProps =
    inherit IProps
    /// This component does not support children. 
    abstract children: obj option with get, set
    /// Optional header title. 
    abstract title: React.ReactNode option with get, set

type [<AllowNullLiteral>] MenuDivider =
    inherit React.Component<IMenuDividerProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MenuDividerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MenuDivider
type IProps = ______common_props.IProps
type MenuDivider = __menuDivider.MenuDivider
type MenuItem = __menuItem.MenuItem

type [<AllowNullLiteral>] IExports =
    abstract Menu: MenuStatic

type [<AllowNullLiteral>] IMenuProps =
    inherit IProps
    inherit React.HTMLAttributes<HTMLUListElement>
    /// Whether the menu items in this menu should use a large appearance. 
    abstract large: bool option with get, set
    /// Ref handler that receives the HTML `<ul>` element backing this component. 
    abstract ulRef: (HTMLUListElement option -> obj option) option with get, set

type [<AllowNullLiteral>] Menu =
    inherit React.Component<IMenuProps, obj>
    abstract displayName: string with get, set
    abstract Divider: obj with get, set
    abstract Item: obj with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MenuStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Menu
type HTMLDivProps = ______common_props.HTMLDivProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract NavbarDivider: NavbarDividerStatic

type [<AllowNullLiteral>] INavbarDividerProps =
    inherit IProps
    inherit HTMLDivProps

type [<AllowNullLiteral>] NavbarDivider =
    inherit React.PureComponent<INavbarDividerProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] NavbarDividerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> NavbarDivider
type Alignment = ______common_alignment.Alignment
type HTMLDivProps = ______common_props.HTMLDivProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract NavbarGroup: NavbarGroupStatic

type [<AllowNullLiteral>] INavbarGroupProps =
    inherit IProps
    inherit HTMLDivProps
    /// The side of the navbar on which the group should appear.
    /// The `Alignment` enum provides constants for these values.
    abstract align: Alignment option with get, set

type [<AllowNullLiteral>] NavbarGroup =
    inherit React.PureComponent<INavbarGroupProps, obj>
    abstract displayName: string with get, set
    abstract defaultProps: INavbarGroupProps with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] NavbarGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> NavbarGroup
type HTMLDivProps = ______common_props.HTMLDivProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract NavbarHeading: NavbarHeadingStatic

type [<AllowNullLiteral>] INavbarHeadingProps =
    inherit IProps
    inherit HTMLDivProps

type [<AllowNullLiteral>] NavbarHeading =
    inherit React.PureComponent<INavbarHeadingProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] NavbarHeadingStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> NavbarHeading
type HTMLDivProps = ______common_props.HTMLDivProps
type IProps = ______common_props.IProps
type NavbarDivider = __navbarDivider.NavbarDivider
type NavbarGroup = __navbarGroup.NavbarGroup
type NavbarHeading = __navbarHeading.NavbarHeading

type [<AllowNullLiteral>] IExports =
    abstract Navbar: NavbarStatic

type [<AllowNullLiteral>] INavbarProps =
    inherit IProps
    inherit HTMLDivProps
    /// Whether this navbar should be fixed to the top of the viewport (using CSS `position: fixed`).
    abstract fixedToTop: bool option with get, set

type [<AllowNullLiteral>] Navbar =
    inherit React.PureComponent<INavbarProps, obj>
    abstract displayName: string with get, set
    abstract Divider: obj with get, set
    abstract Group: obj with get, set
    abstract Heading: obj with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] NavbarStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Navbar
type IProps = ______common_props.IProps
type IconName = ___icon_icon.IconName

type [<AllowNullLiteral>] IExports =
    abstract NonIdealState: NonIdealStateStatic

type [<AllowNullLiteral>] INonIdealStateProps =
    inherit IProps
    /// An action to resolve the non-ideal state which appears after `description`. 
    abstract action: JSX.Element option with get, set
    /// Advanced usage: React `children` will appear last (after `action`).
    /// Avoid passing raw strings as they will not receive margins and disrupt the layout flow.
    abstract children: React.ReactNode option with get, set
    /// A longer description of the non-ideal state.
    /// A string or number value will be wrapped in a `<div>` to preserve margins.
    abstract description: React.ReactChild option with get, set
    /// The name of a Blueprint icon or a JSX Element (such as `<Spinner/>`) to render above the title. 
    abstract icon: U2<IconName, JSX.Element> option with get, set
    /// The title of the non-ideal state. 
    abstract title: React.ReactNode option with get, set

type [<AllowNullLiteral>] NonIdealState =
    inherit React.PureComponent<INonIdealStateProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract maybeRenderVisual: unit -> unit

type [<AllowNullLiteral>] NonIdealStateStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> NonIdealState
type Boundary = ______common_boundary.Boundary
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract OverflowList: OverflowListStatic

type [<AllowNullLiteral>] IOverflowListProps<'T> =
    inherit IProps
    /// Which direction the items should collapse from: start or end of the
    /// children. This also determines whether `overflowRenderer` appears before
    /// (`START`) or after (`END`) the visible items.
    abstract collapseFrom: Boundary option with get, set
    /// All items to display in the list. Items that do not fit in the container
    /// will be rendered in the overflow instead.
    abstract items: ResizeArray<'T> with get, set
    /// The number of visible items will never be lower than the number passed to
    /// this prop.
    abstract minVisibleItems: float option with get, set
    /// If `true`, all parent DOM elements of the container will also be
    /// observed. If changes to a parent's size is detected, the overflow will be
    /// recalculated.
    /// 
    /// Only enable this prop if the overflow should be recalculated when a
    /// parent element resizes in a way that does not also cause the
    /// `OverflowList` to resize.
    abstract observeParents: bool option with get, set
    /// Callback invoked to render the overflowed items. Unlike
    /// `visibleItemRenderer`, this prop is invoked once with all items that do
    /// not fit in the container.
    /// 
    /// Typical use cases for this prop will put overflowed items in a dropdown
    /// menu or display a "+X items" label.
    abstract overflowRenderer: (ResizeArray<'T> -> React.ReactNode) with get, set
    /// CSS properties to apply to the root element. 
    abstract style: React.CSSProperties option with get, set
    /// Callback invoked to render each visible item.
    /// Remember to set a `key` on the rendered element!
    abstract visibleItemRenderer: ('T -> float -> React.ReactChild) with get, set

type [<AllowNullLiteral>] IOverflowListState<'T> =
    abstract overflow: ResizeArray<'T> with get, set
    abstract visible: ResizeArray<'T> with get, set

type [<AllowNullLiteral>] OverflowList<'T> =
    inherit React.PureComponent<IOverflowListProps<'T>, IOverflowListState<'T>>
    abstract displayName: string with get, set
    abstract defaultProps: obj with get, set
    abstract state: IOverflowListState<'T> with get, set
    /// A cache containing the widths of all elements being observed to detect growing/shrinking 
    abstract previousWidths: obj with get, set
    abstract spacer: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: nextProps: IOverflowListProps<'T> -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract maybeRenderOverflow: unit -> unit
    abstract resize: obj with get, set
    abstract repartition: growing: obj -> unit

type [<AllowNullLiteral>] OverflowListStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> OverflowList<'T>
    abstract ofType: unit -> obj
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Text: TextStatic

type [<AllowNullLiteral>] ITextProps =
    inherit IProps
    /// Indicates that this component should be truncated with an ellipsis if it overflows its container.
    /// The `title` attribute will also be added when content overflows to show the full text of the children on hover.
    abstract ellipsize: bool option with get, set
    /// HTML tag name to use for rendered element.
    abstract tagName: obj option with get, set

type [<AllowNullLiteral>] ITextState =
    abstract textContent: string with get, set
    abstract isContentOverflowing: bool with get, set

type [<AllowNullLiteral>] Text =
    inherit React.PureComponent<ITextProps, ITextState>
    abstract displayName: string with get, set
    abstract state: ITextState with get, set
    abstract textRef: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract update: unit -> unit

type [<AllowNullLiteral>] TextStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Text

type IPanel =
    IPanel<obj>

/// An object describing a panel in a `PanelStack`.
type [<AllowNullLiteral>] IPanel<'P> =
    /// The component type to render for this panel. This must be a reference to
    /// the component class or SFC, _not_ a JSX element, so it can be re-created
    /// dynamically when needed.
    abstract ``component``: React.ComponentType<obj> with get, set
    /// The props passed to the component type when it is rendered. The methods
    /// in `IPanelProps` will be injected by `PanelStack`.
    abstract props: 'P option with get, set
    /// The title to be displayed above this panel. It is also used as the text
    /// of the back button for any panel opened by this panel.
    abstract title: React.ReactNode option with get, set

/// Include this interface in your panel component's props type to access these
/// two functions which are injected by `PanelStack`.
/// 
/// ```tsx
/// import { IPanelProps } from "@blueprintjs/core";
/// export class SettingsPanel extends React.Component<IPanelProps & ISettingsPanelProps> {...}
/// ```
type [<AllowNullLiteral>] IPanelProps =
    /// Call this method to programatically close this panel. If this is the only
    /// panel on the stack then this method will do nothing.
    /// 
    /// Remember that the panel header always contains a "back" button that
    /// closes this panel on click (unless there is only one panel on the stack).
    abstract closePanel: unit -> unit
    /// Call this method to open a new panel on the top of the stack.
    abstract openPanel: panel: IPanel<'P> -> unit
type IProps = ______common_props.IProps
type IPanel = __panelProps.IPanel

type [<AllowNullLiteral>] IExports =
    abstract PanelStack: PanelStackStatic

type [<AllowNullLiteral>] IPanelStackProps =
    inherit IProps
    /// The initial panel to show on mount. This panel cannot be removed from the
    /// stack and will appear when the stack is empty.
    abstract initialPanel: IPanel with get, set
    /// Callback invoked when the user presses the back button or a panel invokes
    /// the `closePanel()` injected prop method.
    abstract onClose: (IPanel -> unit) option with get, set
    /// Callback invoked when a panel invokes the `openPanel(panel)` injected
    /// prop method.
    abstract onOpen: (IPanel -> unit) option with get, set

type [<AllowNullLiteral>] IPanelStackState =
    /// Whether the stack is currently animating the push or pop of a panel. 
    abstract direction: U2<string, string> with get, set
    /// The current stack of panels. The first panel in the stack will be displayed. 
    abstract stack: ResizeArray<IPanel> with get, set

type [<AllowNullLiteral>] PanelStack =
    inherit React.PureComponent<IPanelStackProps, IPanelStackState>
    abstract state: IPanelStackState with get, set
    abstract render: unit -> JSX.Element
    abstract renderCurrentPanel: unit -> unit
    abstract handlePanelClose: obj with get, set
    abstract handlePanelOpen: obj with get, set

type [<AllowNullLiteral>] PanelStackStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PanelStack
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Portal: PortalStatic

type [<AllowNullLiteral>] IPortalProps =
    inherit IProps
    /// Callback invoked when the children of this `Portal` have been added to the DOM.
    abstract onChildrenMount: (unit -> unit) option with get, set

type [<AllowNullLiteral>] IPortalState =
    abstract hasMounted: bool with get, set

type [<AllowNullLiteral>] IPortalContext =
    /// Additional CSS classes to add to all `Portal` elements in this React context. 
    abstract blueprintPortalClassName: string option with get, set

/// This component detaches its contents and re-attaches them to document.body.
/// Use it when you need to circumvent DOM z-stacking (for dialogs, popovers, etc.).
/// Any class names passed to this element will be propagated to the new container element on document.body.
type [<AllowNullLiteral>] Portal =
    inherit React.Component<IPortalProps, IPortalState>
    abstract displayName: string with get, set
    abstract contextTypes: React.ValidationMap<IPortalContext> with get, set
    abstract context: IPortalContext with get, set
    abstract state: IPortalState with get, set
    abstract portalElement: obj with get, set
    abstract render: unit -> React.ReactPortal
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: prevProps: IPortalProps -> unit
    abstract componentWillUnmount: unit -> unit
    abstract createContainerElement: unit -> unit
    abstract unstableRenderNoPortal: unit -> unit

/// This component detaches its contents and re-attaches them to document.body.
/// Use it when you need to circumvent DOM z-stacking (for dialogs, popovers, etc.).
/// Any class names passed to this element will be propagated to the new container element on document.body.
type [<AllowNullLiteral>] PortalStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Portal
type IIntentProps = ______common_props.IIntentProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract ProgressBar: ProgressBarStatic

type [<AllowNullLiteral>] IProgressBarProps =
    inherit IProps
    inherit IIntentProps
    /// Whether the background should animate.
    abstract animate: bool option with get, set
    /// Whether the background should be striped.
    abstract stripes: bool option with get, set
    /// A value between 0 and 1 (inclusive) representing how far along the operation is.
    /// Values below 0 or above 1 will be interpreted as 0 or 1, respectively.
    /// Omitting this prop will result in an "indeterminate" progress meter that fills the entire bar.
    abstract value: float option with get, set

type [<AllowNullLiteral>] ProgressBar =
    inherit React.PureComponent<IProgressBarProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ProgressBarStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ProgressBar

type [<AllowNullLiteral>] IExports =
    abstract ResizeSensor: ResizeSensorStatic

/// A parallel type to `ResizeObserverEntry` (from resize-observer-polyfill). 
type [<AllowNullLiteral>] IResizeEntry =
    /// Measured dimensions of the target. 
    abstract contentRect: DOMRectReadOnly with get, set
    /// The resized element. 
    abstract target: Element with get, set

/// `ResizeSensor` requires a single DOM element child and will error otherwise. 
type [<AllowNullLiteral>] IResizeSensorProps =
    /// Callback invoked when the wrapped element resizes.
    /// 
    /// The `entries` array contains an entry for each observed element. In the
    /// default case (no `observeParents`), the array will contain only one
    /// element: the single child of the `ResizeSensor`.
    /// 
    /// Note that this method is called _asynchronously_ after a resize is
    /// detected and typically it will be called no more than once per frame.
    abstract onResize: (ResizeArray<IResizeEntry> -> unit) with get, set
    /// If `true`, all parent DOM elements of the container will also be
    /// observed for size changes. The array of entries passed to `onResize`
    /// will now contain an entry for each parent element up to the root of the
    /// document.
    /// 
    /// Only enable this prop if a parent element resizes in a way that does
    /// not also cause the child element to resize.
    abstract observeParents: bool option with get, set

type [<AllowNullLiteral>] ResizeSensor =
    inherit React.PureComponent<IResizeSensorProps>
    abstract displayName: string with get, set
    abstract element: obj with get, set
    abstract observer: obj with get, set
    abstract render: unit -> React.ReactElement<obj option>
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: prevProps: IResizeSensorProps -> unit
    abstract componentWillUnmount: unit -> unit
    /// Observe the given element, if defined and different from the currently
    /// observed element. Pass `force` argument to skip element checks and always
    /// re-observe.
    abstract observeElement: element: obj * ?force: obj -> unit

type [<AllowNullLiteral>] ResizeSensorStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ResizeSensor
type Intent = ______common.Intent
type IProps = ______common.IProps
let [<Import("*","@blueprintjs/core/lib/cjs/components/slider/handleProps")>] HandleType: obj = jsNative
let [<Import("*","@blueprintjs/core/lib/cjs/components/slider/handleProps")>] HandleInteractionKind: obj = jsNative

type HandleType =
    obj

type HandleInteractionKind =
    obj

type [<AllowNullLiteral>] IHandleProps =
    inherit IProps
    /// Numeric value of this handle. 
    abstract value: float with get, set
    /// Intent for the track segment immediately after this handle, taking priority over `intentBefore`. 
    abstract intentAfter: Intent option with get, set
    /// Intent for the track segment immediately before this handle. 
    abstract intentBefore: Intent option with get, set
    /// How this handle interacts with other handles.
    abstract interactionKind: HandleInteractionKind option with get, set
    /// Callback invoked when this handle's value is changed due to a drag
    /// interaction. Note that "push" interactions can cause multiple handles to
    /// update at the same time.
    abstract onChange: (float -> unit) option with get, set
    /// Callback invoked when this handle is released (the end of a drag interaction). 
    abstract onRelease: (float -> unit) option with get, set
    /// Handle appearance type.
    abstract ``type``: HandleType option with get, set
type Intent = ______common.Intent
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IProps = ______common_props.IProps
type IHandleProps = __handleProps.IHandleProps

type [<AllowNullLiteral>] IExports =
    abstract MultiSlider: MultiSliderStatic

/// A convenience type for React's optional children prop. 
type [<AllowNullLiteral>] IChildrenProps =
    abstract children: React.ReactNode option with get, set

type [<AllowNullLiteral>] ISliderBaseProps =
    inherit IProps
    /// Whether the slider is non-interactive.
    abstract disabled: bool option with get, set
    /// Increment between successive labels. Must be greater than zero.
    abstract labelStepSize: float option with get, set
    /// Number of decimal places to use when rendering label value. Default value is the number of
    /// decimals used in the `stepSize` prop. This prop has _no effect_ if you supply a custom
    /// `labelRenderer` callback.
    abstract labelPrecision: float option with get, set
    /// Maximum value of the slider.
    abstract max: float option with get, set
    /// Minimum value of the slider.
    abstract min: float option with get, set
    /// Whether a solid bar should be rendered on the track between current and initial values,
    /// or between handles for `RangeSlider`.
    abstract showTrackFill: bool option with get, set
    /// Increment between successive values; amount by which the handle moves. Must be greater than zero.
    abstract stepSize: float option with get, set
    /// Callback to render a single label. Useful for formatting numbers as currency or percentages.
    /// If `true`, labels will use number value formatted to `labelPrecision` decimal places.
    /// If `false`, labels will not be shown.
    abstract labelRenderer: U2<bool, (float -> U2<string, JSX.Element>)> option with get, set
    /// Whether to show the slider in a vertical orientation.
    abstract vertical: bool option with get, set

type [<AllowNullLiteral>] IMultiSliderProps =
    inherit ISliderBaseProps
    /// Default intent of a track segment, used only if no handle specifies `intentBefore/After`. 
    abstract defaultTrackIntent: Intent option with get, set
    /// Callback invoked when a handle value changes. Receives handle values in sorted order. 
    abstract onChange: values: ResizeArray<float> -> unit
    /// Callback invoked when a handle is released. Receives handle values in sorted order. 
    abstract onRelease: values: ResizeArray<float> -> unit

type [<AllowNullLiteral>] ISliderState =
    abstract labelPrecision: float option with get, set
    /// the client size, in pixels, of one tick 
    abstract tickSize: float option with get, set
    /// the size of one tick as a ratio of the component's client size 
    abstract tickSizeRatio: float option with get, set

type [<AllowNullLiteral>] MultiSlider =
    inherit AbstractPureComponent<IMultiSliderProps, ISliderState>
    abstract defaultSliderProps: ISliderBaseProps with get, set
    abstract defaultProps: IMultiSliderProps with get, set
    abstract displayName: string with get, set
    abstract Handle: React.SFC<IHandleProps> with get, set
    abstract state: ISliderState with get, set
    abstract handleElements: obj with get, set
    abstract handleProps: obj with get, set
    abstract trackElement: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentWillMount: unit -> unit
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract componentWillReceiveProps: nextProps: obj -> unit
    abstract validateProps: props: obj -> unit
    abstract formatLabel: value: obj -> unit
    abstract renderLabels: unit -> unit
    abstract renderTracks: unit -> unit
    abstract renderTrackFill: index: obj * start: obj * ``end``: obj -> unit
    abstract renderHandles: unit -> unit
    abstract addHandleRef: obj with get, set
    abstract maybeHandleTrackClick: obj with get, set
    abstract maybeHandleTrackTouch: obj with get, set
    abstract canHandleTrackEvent: obj with get, set
    abstract nearestHandleForValue: handles: obj * getOffset: obj -> unit
    abstract getHandlerForIndex: obj with get, set
    abstract getNewHandleValues: newValue: obj * oldIndex: obj -> unit
    abstract findFirstLockedHandleIndex: startIndex: obj * endIndex: obj -> unit
    abstract handleChange: obj with get, set
    abstract handleRelease: obj with get, set
    abstract getLabelPrecision: {labelPrecision, stepSize}: obj -> unit
    abstract getOffsetRatio: value: obj -> unit
    abstract getTrackIntent: start: obj * ?``end``: obj -> unit
    abstract updateTickSize: unit -> unit

type [<AllowNullLiteral>] MultiSliderStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MultiSlider
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type ISliderBaseProps = __multiSlider.ISliderBaseProps

type [<AllowNullLiteral>] IExports =
    abstract RangeSlider: RangeSliderStatic

type NumberRange =
    float * float

type [<AllowNullLiteral>] IRangeSliderProps =
    inherit ISliderBaseProps
    /// Range value of slider. Handles will be rendered at each position in the range.
    abstract value: NumberRange option with get, set
    /// Callback invoked when the range value changes. 
    abstract onChange: value: NumberRange -> unit
    /// Callback invoked when a handle is released. 
    abstract onRelease: value: NumberRange -> unit

type [<AllowNullLiteral>] RangeSlider =
    inherit AbstractPureComponent<IRangeSliderProps>
    abstract defaultProps: IRangeSliderProps with get, set
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract validateProps: props: IRangeSliderProps -> unit

type [<AllowNullLiteral>] RangeSliderStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> RangeSlider
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type ISliderBaseProps = __multiSlider.ISliderBaseProps

type [<AllowNullLiteral>] IExports =
    abstract Slider: SliderStatic

type [<AllowNullLiteral>] ISliderProps =
    inherit ISliderBaseProps
    /// Initial value of the slider. This determines the other end of the
    /// track fill: from `initialValue` to `value`.
    abstract initialValue: float option with get, set
    /// Value of slider.
    abstract value: float option with get, set
    /// Callback invoked when the value changes. 
    abstract onChange: value: float -> unit
    /// Callback invoked when the handle is released. 
    abstract onRelease: value: float -> unit

type [<AllowNullLiteral>] Slider =
    inherit AbstractPureComponent<ISliderProps>
    abstract defaultProps: ISliderProps with get, set
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] SliderStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Slider
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IIntentProps = ______common_props.IIntentProps
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Spinner: SpinnerStatic

type [<AllowNullLiteral>] ISpinnerProps =
    inherit IProps
    inherit IIntentProps
    /// Width and height of the spinner in pixels. The size cannot be less than
    /// 10px. Constants are available for common sizes: `Spinner.SIZE_SMALL`,
    /// `Spinner.SIZE_STANDARD`, `Spinner.SIZE_LARGE`.
    abstract size: float option with get, set
    /// HTML tag for the wrapper element. If rendering a `<Spinner>` inside an
    /// `<svg>`, change this to an SVG element like `"g"`.
    abstract tagName: obj option with get, set
    /// A value between 0 and 1 (inclusive) representing how far along the operation is.
    /// Values below 0 or above 1 will be interpreted as 0 or 1 respectively.
    /// Omitting this prop will result in an "indeterminate" spinner where the head spins indefinitely.
    abstract value: float option with get, set

type [<AllowNullLiteral>] Spinner =
    inherit AbstractPureComponent<ISpinnerProps, obj>
    abstract displayName: string with get, set
    abstract SIZE_SMALL: float
    abstract SIZE_STANDARD: float
    abstract SIZE_LARGE: float
    abstract componentDidUpdate: prevProps: ISpinnerProps -> unit
    abstract render: unit -> JSX.Element
    abstract validateProps: {className, size}: ISpinnerProps -> unit
    abstract getSize: unit -> unit

type [<AllowNullLiteral>] SpinnerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Spinner
type IProps = ______common_props.IProps

type [<AllowNullLiteral>] IExports =
    abstract Tab: TabStatic

type TabId =
    U2<string, float>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module TabId =
    let ofString v: TabId = v |> U2.Case1
    let isString (v: TabId) = match v with U2.Case1 _ -> true | _ -> false
    let asString (v: TabId) = match v with U2.Case1 o -> Some o | _ -> None
    let ofFloat v: TabId = v |> U2.Case2
    let isFloat (v: TabId) = match v with U2.Case2 _ -> true | _ -> false
    let asFloat (v: TabId) = match v with U2.Case2 o -> Some o | _ -> None

type [<AllowNullLiteral>] ITabProps =
    inherit IProps
    /// Content of tab title, rendered in a list above the active panel.
    /// Can also be set via the `title` prop.
    abstract children: React.ReactNode option with get, set
    /// Whether the tab is disabled.
    abstract disabled: bool option with get, set
    /// Unique identifier used to control which tab is selected
    /// and to generate ARIA attributes for accessibility.
    abstract id: TabId with get, set
    /// Panel content, rendered by the parent `Tabs` when this tab is active.
    /// If omitted, no panel will be rendered for this tab.
    abstract panel: JSX.Element option with get, set
    /// Content of tab title element, rendered in a list above the active panel.
    /// Can also be set via React `children`.
    abstract title: React.ReactNode option with get, set

type [<AllowNullLiteral>] Tab =
    inherit React.PureComponent<ITabProps, obj>
    abstract defaultProps: ITabProps with get, set
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] TabStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Tab
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IProps = ______common_props.IProps
type Tab = __tab.Tab
type TabId = __tab.TabId
let [<Import("*","@blueprintjs/core/lib/cjs/components/tabs/tabs")>] Expander: React.SFC<obj> = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Tabs: TabsStatic

type [<AllowNullLiteral>] ITabsProps =
    inherit IProps
    /// Whether the selected tab indicator should animate its movement.
    abstract animate: bool option with get, set
    /// Initial selected tab `id`, for uncontrolled usage.
    /// Note that this prop refers only to `<Tab>` children; other types of elements are ignored.
    abstract defaultSelectedTabId: TabId option with get, set
    /// Unique identifier for this `Tabs` container. This will be combined with the `id` of each
    /// `Tab` child to generate ARIA accessibility attributes. IDs are required and should be
    /// unique on the page to support server-side rendering.
    abstract id: TabId with get, set
    /// If set to `true`, the tab titles will display with larger styling.
    /// This will apply large styles only to the tabs at this level, not to nested tabs.
    abstract large: bool option with get, set
    /// Whether inactive tab panels should be removed from the DOM and unmounted in React.
    /// This can be a performance enhancement when rendering many complex panels, but requires
    /// careful support for unmounting and remounting.
    abstract renderActiveTabPanelOnly: bool option with get, set
    /// Selected tab `id`, for controlled usage.
    /// Providing this prop will put the component in controlled mode.
    /// Unknown ids will result in empty selection (no errors).
    abstract selectedTabId: TabId option with get, set
    /// Whether to show tabs stacked vertically on the left side.
    abstract vertical: bool option with get, set
    /// A callback function that is invoked when a tab in the tab list is clicked.
    abstract onChange: newTabId: TabId * prevTabId: TabId * ``event``: React.MouseEvent<HTMLElement> -> unit

type [<AllowNullLiteral>] ITabsState =
    abstract indicatorWrapperStyle: React.CSSProperties option with get, set
    abstract selectedTabId: TabId option with get, set

type [<AllowNullLiteral>] Tabs =
    inherit AbstractPureComponent<ITabsProps, ITabsState>
    /// Insert a `Tabs.Expander` between any two children to right-align all subsequent children. 
    abstract Expander: React.StatelessComponent<obj> with get, set
    abstract Tab: obj with get, set
    abstract defaultProps: obj with get, set
    abstract displayName: string with get, set
    abstract tablistElement: obj with get, set
    abstract refHandlers: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: {selectedTabId}: ITabsProps -> unit
    abstract componentDidUpdate: prevProps: ITabsProps * prevState: ITabsState -> unit
    abstract getInitialSelectedTabId: unit -> unit
    abstract getKeyCodeDirection: e: obj -> unit
    abstract getTabChildrenProps: ?props: obj -> unit
    /// Filters children to only `<Tab>`s 
    abstract getTabChildren: ?props: obj -> unit
    /// Queries root HTML element for all tabs with optional filter selector 
    abstract getTabElements: ?subselector: obj -> unit
    abstract handleKeyDown: obj with get, set
    abstract handleKeyPress: obj with get, set
    abstract handleTabClick: obj with get, set
    /// Calculate the new height, width, and position of the tab indicator.
    /// Store the CSS values so the transition animation can start.
    abstract moveSelectionIndicator: unit -> unit
    abstract renderTabPanel: obj with get, set
    abstract renderTabTitle: obj with get, set

type [<AllowNullLiteral>] TabsStatic =
    [<Emit "new $0($1...)">] abstract Create: ?props: ITabsProps -> Tabs
type IIntentProps = ______common.IIntentProps
type IProps = ______common.IProps
type IconName = ___icon_icon.IconName

type [<AllowNullLiteral>] IExports =
    abstract Tag: TagStatic

type [<AllowNullLiteral>] ITagProps =
    inherit IProps
    inherit IIntentProps
    inherit React.HTMLAttributes<HTMLSpanElement>
    /// Whether the tag should appear in an active state.
    abstract active: bool option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render before the children. 
    abstract icon: U2<IconName, JSX.Element> option with get, set
    /// Whether the tag should visually respond to user interactions. If set
    /// to `true`, hovering over the tag will change its color and mouse cursor.
    /// 
    /// Recommended when `onClick` is also defined.
    abstract interactive: bool option with get, set
    /// Whether this tag should use large styles.
    abstract large: bool option with get, set
    /// Whether this tag should use minimal styles.
    abstract minimal: bool option with get, set
    /// Whether tag content should be allowed to occupy multiple lines.
    /// If false, a single line of text will be truncated with an ellipsis if
    /// it overflows. Note that icons will be vertically centered relative to
    /// multiline text.
    abstract multiline: bool option with get, set
    /// Callback invoked when the tag is clicked.
    /// Recommended when `interactive` is `true`.
    abstract onClick: (React.MouseEvent<HTMLDivElement> -> unit) option with get, set
    /// Click handler for remove button.
    /// The remove button will only be rendered if this prop is defined.
    abstract onRemove: (React.MouseEvent<HTMLButtonElement> -> ITagProps -> unit) option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render after the children. 
    abstract rightIcon: U2<IconName, JSX.Element> option with get, set
    /// Whether this tag should have rounded ends.
    abstract round: bool option with get, set

type [<AllowNullLiteral>] Tag =
    inherit React.PureComponent<ITagProps, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract onRemoveClick: obj with get, set

type [<AllowNullLiteral>] TagStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Tag
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type HTMLInputProps = ______common_props.HTMLInputProps
type IProps = ______common_props.IProps
type IconName = ___icon_icon.IconName
type ITagProps = ___tag_tag.ITagProps

type [<AllowNullLiteral>] IExports =
    abstract TagInput: TagInputStatic

type [<AllowNullLiteral>] ITagInputProps =
    inherit IProps
    /// If true, `onAdd` will be invoked when the input loses focus.
    /// Otherwise, `onAdd` is only invoked when `enter` is pressed.
    abstract addOnBlur: bool option with get, set
    /// If true, `onAdd` will be invoked when the user pastes text containing the `separator`
    /// into the input. Otherwise, pasted text will remain in the input.
    /// 
    /// __Note:__ For example, if `addOnPaste=true` and `separator="\n"` (new line), then:
    /// - Pasting `"hello"` will _not_ invoke `onAdd`
    /// - Pasting `"hello\n"` will invoke `onAdd` with `["hello"]`
    /// - Pasting `"hello\nworld"` will invoke `onAdd` with `["hello", "world"]`
    abstract addOnPaste: bool option with get, set
    /// Whether the component is non-interactive.
    /// Note that you'll also need to disable the component's `rightElement`,
    /// if appropriate.
    abstract disabled: bool option with get, set
    /// Whether the tag input should take up the full width of its container. 
    abstract fill: bool option with get, set
    /// React props to pass to the `<input>` element.
    /// Note that `ref` and `key` are not supported here; use `inputRef` below.
    abstract inputProps: HTMLInputProps option with get, set
    /// Ref handler for the `<input>` element. 
    abstract inputRef: (HTMLInputElement option -> unit) option with get, set
    /// Controlled value of the `<input>` element. This is shorthand for `inputProps={{ value }}`. 
    abstract inputValue: string option with get, set
    /// Whether the tag input should use a large size. 
    abstract large: bool option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render on the left side of the input. 
    abstract leftIcon: U2<IconName, JSX.Element> option with get, set
    /// Callback invoked when new tags are added by the user pressing `enter` on the input.
    /// Receives the current value of the input field split by `separator` into an array.
    /// New tags are expected to be appended to the list.
    /// 
    /// The input will be cleared after `onAdd` is invoked _unless_ the callback explicitly
    /// returns `false`. This is useful if the provided `value` is somehow invalid and should
    /// not be added as a tag.
    abstract onAdd: (ResizeArray<string> -> U2<bool, unit>) option with get, set
    /// Callback invoked when new tags are added or removed. Receives the updated list of `values`:
    /// new tags are appended to the end of the list, removed tags are removed at their index.
    /// 
    /// Like `onAdd`, the input will be cleared after this handler is invoked _unless_ the callback
    /// explicitly returns `false`.
    /// 
    /// This callback essentially implements basic `onAdd` and `onRemove` functionality and merges
    /// the two handlers into one to simplify controlled usage.
    /// 
    /// **Note about typed usage:** Your handler can declare a subset type of `React.ReactNode[]`,
    /// such as `string[]` or `Array<string | JSX.Element>`, to match the type of your `values` array:
    /// ```tsx
    /// <TagInput
    ///      onChange={(values: string[]) => this.setState({ values })}
    ///      values={["apple", "banana", "cherry"]}
    /// />
    /// ```
    abstract onChange: (ResizeArray<React.ReactNode> -> U2<bool, unit>) option with get, set
    /// Callback invoked when the value of `<input>` element is changed.
    /// This is shorthand for `inputProps={{ onChange }}`.
    abstract onInputChange: React.FormEventHandler<HTMLInputElement> option with get, set
    /// Callback invoked when the user depresses a keyboard key.
    /// Receives the event and the index of the active tag (or `undefined` if
    /// focused in the input).
    abstract onKeyDown: (React.KeyboardEvent<HTMLElement> -> float -> unit) option with get, set
    /// Callback invoked when the user releases a keyboard key.
    /// Receives the event and the index of the active tag (or `undefined` if
    /// focused in the input).
    abstract onKeyUp: (React.KeyboardEvent<HTMLElement> -> float -> unit) option with get, set
    /// Callback invoked when the user clicks the X button on a tag.
    /// Receives value and index of removed tag.
    abstract onRemove: (string -> float -> unit) option with get, set
    /// Input placeholder text which will not appear if `values` contains any items
    /// (consistent with default HTML input behavior).
    /// Use `inputProps.placeholder` if you want the placeholder text to _always_ appear.
    /// 
    /// If you define both `placeholder` and `inputProps.placeholder`, then the former will appear
    /// when `values` is empty and the latter at all other times.
    abstract placeholder: string option with get, set
    /// Element to render on right side of input.
    /// For best results, use a small spinner or minimal button (button height will adjust if `TagInput` uses large styles).
    /// Other elements will likely require custom styles for correct positioning.
    abstract rightElement: JSX.Element option with get, set
    /// Separator pattern used to split input text into multiple values. Default value splits on commas and newlines.
    /// Explicit `false` value disables splitting (note that `onAdd` will still receive an array of length 1).
    abstract separator: U3<string, RegExp, obj> option with get, set
    /// React props to pass to each `Tag`. Provide an object to pass the same props to every tag,
    /// or a function to customize props per tag.
    /// 
    /// If you define `onRemove` here then you will have to implement your own tag removal
    /// handling as `TagInput`'s own `onRemove` handler will never be invoked.
    abstract tagProps: U2<ITagProps, (React.ReactNode -> float -> ITagProps)> option with get, set
    /// Controlled tag values. Each value will be rendered inside a `Tag`, which can be customized
    /// using `tagProps`. Therefore, any valid React node can be used as a `TagInput` value; falsy
    /// values will not be rendered.
    /// 
    /// __Note about typed usage:__ If you know your `values` will always be of a certain `ReactNode`
    /// subtype, such as `string` or `ReactChild`, you can use that type on all your handlers
    /// to simplify type logic.
    abstract values: ResizeArray<React.ReactNode> with get, set

type [<AllowNullLiteral>] ITagInputState =
    abstract activeIndex: float option with get, set
    abstract inputValue: string option with get, set
    abstract isInputFocused: bool option with get, set

type [<AllowNullLiteral>] TagInput =
    inherit AbstractPureComponent<ITagInputProps, ITagInputState>
    abstract displayName: string with get, set
    abstract defaultProps: obj with get, set
    abstract state: ITagInputState with get, set
    abstract inputElement: obj with get, set
    abstract refHandlers: obj with get, set
    abstract componentWillReceiveProps: nextProps: obj -> unit
    abstract render: unit -> JSX.Element
    abstract addTags: obj with get, set
    abstract maybeRenderTag: obj with get, set
    abstract getNextActiveIndex: direction: obj -> unit
    abstract findNextIndex: startIndex: obj * direction: obj -> unit
    /// Splits inputValue on separator prop,
    /// trims whitespace from each new value,
    /// and ignores empty values.
    abstract getValues: inputValue: obj -> unit
    abstract handleContainerClick: obj with get, set
    abstract handleContainerBlur: obj with get, set
    abstract handleInputFocus: obj with get, set
    abstract handleInputChange: obj with get, set
    abstract handleInputKeyDown: obj with get, set
    abstract handleInputKeyUp: obj with get, set
    abstract handleInputPaste: obj with get, set
    abstract handleRemoveTag: obj with get, set
    abstract handleBackspaceToRemove: ``event``: obj -> unit
    /// Remove the item at the given index by invoking `onRemove` and `onChange` accordingly. 
    abstract removeIndexFromValues: index: obj -> unit
    abstract invokeKeyPressCallback: propCallbackName: obj * ``event``: obj * activeIndex: obj -> unit
    /// Returns whether the given index represents a valid item in `this.props.values`. 
    abstract isValidIndex: index: obj -> unit

type [<AllowNullLiteral>] TagInputStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> TagInput
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type IActionProps = ______common_props.IActionProps
type IIntentProps = ______common_props.IIntentProps
type ILinkProps = ______common_props.ILinkProps
type IProps = ______common_props.IProps
type IconName = ___icon_icon.IconName

type [<AllowNullLiteral>] IExports =
    abstract Toast: ToastStatic

type [<AllowNullLiteral>] IToastProps =
    inherit IProps
    inherit IIntentProps
    /// Action rendered as a minimal `AnchorButton`. The toast is dismissed automatically when the
    /// user clicks the action button. Note that the `intent` prop is ignored (the action button
    /// cannot have its own intent color that might conflict with the toast's intent). Omit this
    /// prop to omit the action button.
    abstract action: obj option with get, set
    /// Name of a Blueprint UI icon (or an icon element) to render before the message. 
    abstract icon: U2<IconName, JSX.Element> option with get, set
    /// Message to display in the body of the toast. 
    abstract message: U2<string, JSX.Element> with get, set
    /// Callback invoked when the toast is dismissed, either by the user or by the timeout.
    /// The value of the argument indicates whether the toast was closed because the timeout expired.
    abstract onDismiss: (bool -> unit) option with get, set
    /// Milliseconds to wait before automatically dismissing toast.
    /// Providing a value less than or equal to 0 will disable the timeout (this is discouraged).
    abstract timeout: float option with get, set

type [<AllowNullLiteral>] Toast =
    inherit AbstractPureComponent<IToastProps, obj>
    abstract defaultProps: IToastProps with get, set
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: prevProps: IToastProps -> unit
    abstract componentWillUnmount: unit -> unit
    abstract maybeRenderActionButton: unit -> unit
    abstract handleActionClick: obj with get, set
    abstract handleCloseClick: obj with get, set
    abstract triggerDismiss: didTimeoutExpire: obj -> unit
    abstract startTimeout: obj with get, set

type [<AllowNullLiteral>] ToastStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Toast
type AbstractPureComponent = ______common_abstractPureComponent.AbstractPureComponent
type Position = ______common_position.Position
type IProps = ______common_props.IProps
type IToastProps = __toast.IToastProps

type [<AllowNullLiteral>] IExports =
    abstract Toaster: ToasterStatic

type [<AllowNullLiteral>] IToastOptions =
    interface end

type ToasterPosition =
    obj

/// Instance methods available on a `<Toaster>` component instance. 
type [<AllowNullLiteral>] IToaster =
    /// Shows a new toast to the user, or updates an existing toast corresponding to the provided key (optional).
    /// 
    /// Returns the unique key of the toast.
    abstract show: props: IToastProps * ?key: string -> string
    /// Dismiss the given toast instantly. 
    abstract dismiss: key: string -> unit
    /// Dismiss all toasts instantly. 
    abstract clear: unit -> unit
    /// Returns the props for all current toasts. 
    abstract getToasts: unit -> ResizeArray<IToastOptions>

/// Props supported by the `<Toaster>` component.
/// These props can be passed as an argument to the static `Toaster.create(props?, container?)` method.
type [<AllowNullLiteral>] IToasterProps =
    inherit IProps
    /// Whether a toast should acquire application focus when it first opens.
    /// This is disabled by default so that toasts do not interrupt the user's flow.
    /// Note that `enforceFocus` is always disabled for `Toaster`s.
    abstract autoFocus: bool option with get, set
    /// Whether pressing the `esc` key should clear all active toasts.
    abstract canEscapeKeyClear: bool option with get, set
    /// Whether the toaster should be rendered into a new element attached to `document.body`.
    /// If `false`, then positioning will be relative to the parent element.
    /// 
    /// This prop is ignored by `Toaster.create()` as that method always appends a new element
    /// to the container.
    abstract usePortal: bool option with get, set
    /// Position of `Toaster` within its container.
    /// 
    /// Note that only `TOP` and `BOTTOM` are supported because Toaster only
    /// supports the top and bottom edge positioning.
    abstract position: ToasterPosition option with get, set

type [<AllowNullLiteral>] IToasterState =
    abstract toasts: ResizeArray<IToastOptions> with get, set

type [<AllowNullLiteral>] Toaster =
    inherit AbstractPureComponent<IToasterProps, IToasterState>
    inherit IToaster
    abstract displayName: string with get, set
    abstract defaultProps: IToasterProps with get, set
    abstract state: obj with get, set
    abstract toastId: obj with get, set
    abstract show: props: IToastProps * ?key: string -> string
    abstract dismiss: key: string * ?timeoutExpired: bool -> unit
    abstract clear: unit -> unit
    abstract getToasts: unit -> ResizeArray<IToastOptions>
    abstract render: unit -> JSX.Element
    abstract isNewToastKey: key: obj -> unit
    abstract renderToast: toast: obj -> unit
    abstract createToastOptions: props: obj * ?key: obj -> unit
    abstract getPositionClasses: unit -> unit
    abstract getDismissHandler: obj with get, set
    abstract handleClose: obj with get, set

type [<AllowNullLiteral>] ToasterStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Toaster
    /// Create a new `Toaster` instance that can be shared around your application.
    /// The `Toaster` will be rendered into a new element appended to the given container.
    abstract create: ?props: IToasterProps * ?container: HTMLElement -> IToaster
type IIntentProps = ______common_props.IIntentProps
type IPopoverSharedProps = ___popover_popoverSharedProps.IPopoverSharedProps

type [<AllowNullLiteral>] IExports =
    abstract Tooltip: TooltipStatic

type [<AllowNullLiteral>] ITooltipProps =
    inherit IPopoverSharedProps
    inherit IIntentProps
    /// The content that will be displayed inside of the tooltip.
    abstract content: U2<JSX.Element, string> with get, set
    /// The amount of time in milliseconds the tooltip should remain open after
    /// the user hovers off the trigger. The timer is canceled if the user mouses
    /// over the target before it expires.
    abstract hoverCloseDelay: float option with get, set
    /// The amount of time in milliseconds the tooltip should wait before opening
    /// after the user hovers over the trigger. The timer is canceled if the user
    /// mouses away from the target before it expires.
    abstract hoverOpenDelay: float option with get, set
    /// Indicates how long (in milliseconds) the tooltip's appear/disappear
    /// transition takes. This is used by React `CSSTransition` to know when a
    /// transition completes and must match the duration of the animation in CSS.
    /// Only set this prop if you override Blueprint's default transitions with
    /// new transitions of a different length.
    abstract transitionDuration: float option with get, set

type [<AllowNullLiteral>] Tooltip =
    inherit React.PureComponent<ITooltipProps, obj>
    abstract displayName: string with get, set
    abstract defaultProps: obj with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] TooltipStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Tooltip
type IProps = ______common_props.IProps
type IconName = ___icon_icon.IconName

type [<AllowNullLiteral>] IExports =
    abstract TreeNode: TreeNodeStatic

type ITreeNode =
    ITreeNode<obj>

type [<AllowNullLiteral>] ITreeNode<'T> =
    inherit IProps
    /// Child tree nodes of this node.
    abstract childNodes: Array<ITreeNode<'T>> option with get, set
    /// Whether the caret to expand/collapse a node should be shown.
    /// If not specified, this will be true if the node has children and false otherwise.
    abstract hasCaret: bool option with get, set
    /// The name of a Blueprint icon (or an icon element) to render next to the node's label.
    abstract icon: U2<IconName, JSX.Element> option with get, set
    /// A unique identifier for the node.
    abstract id: U2<string, float> with get, set
    abstract isExpanded: bool option with get, set
    /// Whether this node is selected.
    abstract isSelected: bool option with get, set
    /// The main label for the node.
    abstract label: U2<string, JSX.Element> with get, set
    /// A secondary label/component that is displayed at the right side of the node.
    abstract secondaryLabel: U2<string, JSX.Element> option with get, set
    /// An optional custom user object to associate with the node.
    /// This property can then be used in the `onClick`, `onContextMenu` and `onDoubleClick`
    /// event handlers for doing custom logic per node.
    abstract nodeData: 'T option with get, set

type ITreeNodeProps =
    ITreeNodeProps<obj>

type [<AllowNullLiteral>] ITreeNodeProps<'T> =
    inherit ITreeNode<'T>
    abstract children: React.ReactNode option with get, set
    abstract contentRef: (TreeNode<'T> -> HTMLDivElement option -> unit) option with get, set
    abstract depth: float with get, set
    abstract key: U2<string, float> option with get, set
    abstract onClick: (TreeNode<'T> -> React.MouseEvent<HTMLDivElement> -> unit) option with get, set
    abstract onCollapse: (TreeNode<'T> -> React.MouseEvent<HTMLSpanElement> -> unit) option with get, set
    abstract onContextMenu: (TreeNode<'T> -> React.MouseEvent<HTMLDivElement> -> unit) option with get, set
    abstract onDoubleClick: (TreeNode<'T> -> React.MouseEvent<HTMLDivElement> -> unit) option with get, set
    abstract onExpand: (TreeNode<'T> -> React.MouseEvent<HTMLSpanElement> -> unit) option with get, set
    abstract path: ResizeArray<float> with get, set

type TreeNode =
    TreeNode<obj>

type [<AllowNullLiteral>] TreeNode<'T> =
    inherit React.Component<ITreeNodeProps<'T>, obj>
    abstract displayName: string with get, set
    abstract render: unit -> JSX.Element
    abstract maybeRenderSecondaryLabel: unit -> unit
    abstract handleCaretClick: obj with get, set
    abstract handleClick: obj with get, set
    abstract handleContentRef: obj with get, set
    abstract handleContextMenu: obj with get, set
    abstract handleDoubleClick: obj with get, set

type [<AllowNullLiteral>] TreeNodeStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> TreeNode<'T>
    abstract ofType: unit -> obj
type IProps = ______common_props.IProps
type ITreeNode = __treeNode.ITreeNode

type [<AllowNullLiteral>] IExports =
    abstract Tree: TreeStatic

type TreeEventHandler =
    TreeEventHandler<obj>

type [<AllowNullLiteral>] TreeEventHandler<'T> =
    [<Emit "$0($1...)">] abstract Invoke: node: ITreeNode<'T> * nodePath: ResizeArray<float> * e: React.MouseEvent<HTMLElement> -> unit

type ITreeProps =
    ITreeProps<obj>

type [<AllowNullLiteral>] ITreeProps<'T> =
    inherit IProps
    /// The data specifying the contents and appearance of the tree.
    abstract contents: Array<ITreeNode<'T>> with get, set
    /// Invoked when a node is clicked anywhere other than the caret for expanding/collapsing the node.
    abstract onNodeClick: TreeEventHandler<'T> option with get, set
    /// Invoked when caret of an expanded node is clicked.
    abstract onNodeCollapse: TreeEventHandler<'T> option with get, set
    /// Invoked when a node is right-clicked or the context menu button is pressed on a focused node.
    abstract onNodeContextMenu: TreeEventHandler<'T> option with get, set
    /// Invoked when a node is double-clicked. Be careful when using this in combination with
    /// an `onNodeClick` (single-click) handler, as the way this behaves can vary between browsers.
    /// See http://stackoverflow.com/q/5497073/3124288
    abstract onNodeDoubleClick: TreeEventHandler<'T> option with get, set
    /// Invoked when the caret of a collapsed node is clicked.
    abstract onNodeExpand: TreeEventHandler<'T> option with get, set

type Tree =
    Tree<obj>

type [<AllowNullLiteral>] Tree<'T> =
    inherit React.Component<ITreeProps<'T>, obj>
    abstract displayName: string with get, set
    abstract nodeRefs: obj with get, set
    abstract render: unit -> JSX.Element
    /// Returns the underlying HTML element of the `Tree` node with an id of `nodeId`.
    /// This element does not contain the children of the node, only its label and controls.
    /// If the node is not currently mounted, `undefined` is returned.
    abstract getNodeContentElement: nodeId: U2<string, float> -> HTMLElement option
    abstract renderNodes: treeNodes: obj * ?currentPath: obj * ?className: obj -> unit
    abstract handleNodeCollapse: obj with get, set
    abstract handleNodeClick: obj with get, set
    abstract handleContentRef: obj with get, set
    abstract handleNodeContextMenu: obj with get, set
    abstract handleNodeDoubleClick: obj with get, set
    abstract handleNodeExpand: obj with get, set
    abstract handlerHelper: handlerFromProps: obj * node: obj * e: obj -> unit

type [<AllowNullLiteral>] TreeStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Tree<'T>
    abstract ofType: unit -> obj
    abstract nodeFromPath: path: ResizeArray<float> * treeNodes: ResizeArray<ITreeNode> -> ITreeNode
