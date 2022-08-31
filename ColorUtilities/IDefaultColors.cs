namespace ColorUtilities {
public interface IDefaultColors<out T>
{
    T White   { get; }
    T Gray    { get; }
    T Black   { get; }
    T Red     { get; }
    T Orange  { get; }
    T Yellow  { get; }
    T Green   { get; }
    T Brown   { get; }
    T Lime    { get; }
    T Teal    { get; }
    T Cyan    { get; }
    T Blue    { get; }
    T Purple  { get; }
    T Magenta { get; }
    T Pink    { get; }
}
}
