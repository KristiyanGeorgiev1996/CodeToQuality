# 📘 Networks, Internet & Protocols

## 📝 Overview
Networking is all about **communication between devices**. Protocols define the rules for data exchange, ensuring reliable, standardized communication. Networks rely on structured models like **OSI** and **TCP/IP** to simplify communication, troubleshooting, and interoperability. 🌐

---

## ⚙️ Network Protocols
- 🔹 **Network Protocol** – set of rules for data transmission between devices or applications.
- 🔹 Governs addressing, routing, flow control, and error handling.
- 🔹 Standardized in RFC documents (e.g., [RFC 5321](https://www.rfc-editor.org/rfc/rfc5321)).

---

## 🧩 OSI Model (7 Layers)
1. **Physical Layer** – cables, radio, electrical/optical signals. Devices: hubs, antennas. Protocols: Ethernet, Wi-Fi, Bluetooth.  
2. **Data Link Layer** – MAC addresses, frames, error detection. Devices: switches, NICs. Protocols: Ethernet, PPP.  
3. **Network Layer** – routing via IP addresses. Devices: routers. Protocols: IP, ICMP, ARP, IPsec.  
4. **Transport Layer** – ensures reliable data transfer. Protocols: TCP (reliable), UDP (fast, connectionless), QUIC (modern, low-latency).  
5. **Session Layer** – manages sessions, tokens, synchronization. Protocols: SSL/TLS, RPC, SIP, NFS.  
6. **Presentation Layer** – data formats, encryption, compression. Standards: ASCII, UTF-8, JPEG, MPEG.  
7. **Application Layer** – network apps, e.g., web browsers. Protocols: HTTP/HTTPS, FTP, SMTP, IMAP, DNS, SSH.  

---

## 🌐 TCP/IP Model (4 Layers)
- **Link Layer** – Physical + Data Link.
- **Internet Layer** – Logical addressing and routing.
- **Transport Layer** – Reliable or fast data delivery (TCP/UDP).
- **Application Layer** – Combines OSI Session, Presentation, and Application layers.

---

## 🖥 Key Network Elements
- **MAC Address** – 48-bit unique hardware ID for NICs.  
- **IP Address** – identifies devices in a network. IPv4 (32-bit) & IPv6 (128-bit).  
- **Netmask** – determines network portion of an IP.  
- **Gateway** – router IP for Internet access.  
- **Ports** – distinguish processes/services on devices:  
  - TCP ports – connection-oriented, reliable.  
  - UDP ports – fast, connectionless.  
  - Common ports: 22 (SSH), 53 (DNS), 80 (HTTP), 443 (HTTPS), 110 (POP3), 143 (IMAP).  

---

## 🌍 Domain Names, DNS & URLs
- **Domain Name** – human-readable website name (e.g., softuni.org).  
- **DNS** – resolves domains to IP addresses.  
- **URL (Uniform Resource Locator)** – full web address structure:  
  `protocol://subdomain.domain/path?query#fragment`  
  Example: `https://mysite.com:8080/demo/index.php?id=27&lang=en#slides`  

---

## 📡 Web & HTTP
- **HTTP** – text-based request-response protocol for web resources.  
- **Methods**: GET, POST, PUT, DELETE, PATCH, HEAD.  
- **Response Codes**:  
  - 2xx – Success (200 OK, 201 Created)  
  - 3xx – Redirect (301/302)  
  - 4xx – Client error (400 Bad Request, 401 Unauthorized, 404 Not Found)  
  - 5xx – Server error (500 Internal Server Error, 503 Service Unavailable)  

- **Browser DevTools** – inspect HTTP traffic, analyze requests/responses (F12 in Chrome).

---

## 📧 Email Protocols
- **SMTP** – sending emails between servers. Ports: 25 (SMTP), 587 (SMTPS).  
- **IMAP** – retrieve emails from server, sync across devices.  
- **POP** – downloads emails and deletes from server (less flexible).  
- **Forwarding & Filters** – redirect, block, or filter messages; automated via server or client settings.

---

## 💡 Key Takeaways
- Networks rely on **protocols** to ensure proper communication.  
- OSI and TCP/IP models organize communication layers.  
- MAC, IP, gateways, and ports are fundamental for addressing & routing.  
- Web relies on HTTP/HTTPS, DNS, and URLs for resource access.  
- Email uses SMTP, IMAP, and POP for reliable messaging.  
- DevTools allow inspection and debugging of network requests.  
