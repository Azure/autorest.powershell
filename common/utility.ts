function getAllPropertyNames(obj: any) {
  const props = new Array<string>();

  do {
    Object.getOwnPropertyNames(obj).forEach(function (prop) {
      if (props.indexOf(prop) === -1) {
        props.push(prop);
      }
    });
  } while (obj = Object.getPrototypeOf(obj));

  return props;
}
