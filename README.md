Implementimi i One Time Pad duke gjeneruar nje key stream nga nje int32 ose string seed. Implementimi i SymmetricAlgorithm qe ofron enkriptues dhe dekriptues per kete algoritem.

## The OTP
The one-time pad (OTP) is an encryption technique that cannot be cracked, but requires the use of a one-time pre-shared key the same size as, or longer than, the message being sent. In this technique, a plaintext is paired with a random secret key (also referred to as a one-time pad). Then, each bit or character of the plaintext is encrypted by combining it with the corresponding bit or character from the pad using modular addition.

The resulting ciphertext will be impossible to decrypt or break if the following four conditions are met:

- The key must be truly random.
- The key must be at least as long as the plaintext.
- The key must never be reused in whole or in part.
- The key must be kept completely secret.



## Applicability

Despite its problems, the one-time-pad retains some practical interest. In some hypothetical espionage situations, the one-time pad might be useful because it can be computed by hand with only pencil and paper. Indeed, nearly all other high quality ciphers are entirely impractical without computers. In the modern world, however, computers (such as those embedded in personal electronic devices such as mobile phones) are so ubiquitous that possessing a computer suitable for performing conventional encryption (for example, a phone that can run concealed cryptographic software) will usually not attract suspicion.

- The one-time-pad is the optimum cryptosystem with theoretically perfect secrecy.
- The one-time-pad is one of the most practical methods of encryption where one or both parties must do all work by hand, without the aid of a computer. This made it important in the pre-computer era, and it could conceivably still be useful in situations where possession of a computer is illegal or incriminating or where trustworthy computers are not available.
- One-time pads are practical in situations where two parties in a secure environment must be able to depart from one another and communicate from two separate secure environments with perfect secrecy.
- The one-time-pad can be used in superencryption.
- The algorithm most commonly associated with quantum key distribution is the one-time pad.
- The one-time pad is mimicked by stream ciphers.



## Build
