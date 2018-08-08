// Media Type is: type "/" [tree "."] subtype ["+" suffix] * [";" parameter]

const json = 'json';
const xml = 'xml';
const application = 'application';
const text = 'text';
const multipart = 'multipart';
const formData = 'form-data';

export enum KnownMediaType {
  Json = 'application/json',
  Xml = 'application/xml',
  Stream = 'application/octet-stream',
  Text = 'text/plain',

  None = '-none-',
  QueryParameter = '-query-parameter-',
  UriParameter = '-uri-parameter-',

  Header = '-header-',
  Cookie = '-cookie-',

}

export function knownMediaType(mediaType: string) {
  const mt = parseMediaType(mediaType);
  if (mt) {
    if ((mt.subtype === json || mt.suffix === json) && (mt.type === application || mt.type === text)) {
      return KnownMediaType.Json;
    }
    if ((mt.subtype === xml || mt.suffix === xml) && (mt.type === application || mt.type === text)) {
      return KnownMediaType.Xml;
    }
    if (mt.subtype === 'audio' || mt.subtype === 'image' || mt.subtype === 'video' || mt.subtype === "octet-stream") {
      return KnownMediaType.Stream;
    }
  }

  // pseudo-media types for figuring out how to de/serialize from from/to other types.
  switch (mediaType) {
    case 'header':
      return KnownMediaType.Header;
    case 'cookie':
      return KnownMediaType.Cookie;
    case 'urlencoding':
      return KnownMediaType.Cookie;

  }
  return KnownMediaType.None;
}

export function parseMediaType(mediaType: string) {
  if (mediaType) {
    const parsed = /(application|audio|font|example|image|message|model|multipart|text|video|x-(?:[0-9A-Za-z!#$%&'*+.^_`|~-]+))\/([0-9A-Za-z!#$%&'*.^_`|~-]+)\s*(?:\+([0-9A-Za-z!#$%&'*.^_`|~-]+))?\s*(?:;.\s*(\S*))?/g.exec(mediaType);
    if (parsed) {
      return {
        type: parsed[1],
        subtype: parsed[2],
        suffix: parsed[3],
        parameter: parsed[4]
      };
    }
  }
  return undefined;
}

export function normalizeMediaType(contentType: string) {
  if (contentType) {
    const mt = parseMediaType(contentType);
    if (mt) {
      return mt.suffix ?
        `${mt.type}/${mt.subtype}+${mt.suffix}` :
        `${mt.type}/${mt.subtype}`;
    }
  }
  return undefined;
}

export function isMediaTypeJson(mediaType: string): boolean {
  const mt = parseMediaType(mediaType);
  return mt ? (mt.subtype === json || mt.suffix === json) && (mt.type === application || mt.type === text) : false;
}

export function isMediaTypeXml(mediaType: string): boolean {
  const mt = parseMediaType(mediaType);
  return mt ? (mt.subtype === xml || mt.suffix === xml) && (mt.type === application || mt.type === text) : false;
}

export function isMediaTypeMultipartFormData(mediaType: string): boolean {
  const mt = parseMediaType(mediaType);
  return mt ? mt.type === multipart && mt.subtype === formData : false;
}
