export default function dateFilter(value) {
  const options = {
    year: "numeric",
    month: "numeric",
    day: "numeric",
    hour12: false,
  }
  return new Intl.DateTimeFormat("ru-RU", options).format(new Date(value))
}
